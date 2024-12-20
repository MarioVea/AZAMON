﻿using AZAMON.Busquedas;
using AZAMON.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZAMON.formularios
{
    public partial class frmVenta : Form
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public frmVenta()
        {
            InitializeComponent();
            con.ConnectionString = Conexion.conexion;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            tools t = new tools();
            txtId.Text = (t.consecutivo("VENTA").ToString());
            cbCliente(); 
            cbVendedor();
            cbMetodos();
            cbProducto();
            config();
            txtCantidad.Text = "1";
            txtTotal.Text = "$" + sumatoria().ToString();
        }
        DataTable dt = new DataTable();
        void config()
        {
            dt.Columns.Add("id");           //0
            dt.Columns.Add("idVenta");      //1
            dt.Columns.Add("id_Producto");  //2
            dt.Columns.Add("Producto");     //3
            dt.Columns.Add("Cantidad");     //4
            dt.Columns.Add("Importe");      //5
            dgDetalle.DataSource = dt;
        }
        int z = 1;
        void agregar()
        {
            DataRow dr = dt.NewRow();
            dr[0] = z;
            dr[1] = txtId.Text;
            dr[2] = cbProductos.SelectedValue.ToString();
            dr[3] = cbProductos.Text;
            dr[4] = txtCantidad.Text;
            dr[5] = txtImporte.Text;
            z++;
            dt.Rows.Add(dr);
            dgDetalle.DataSource = dt;
        }

        void cbCliente()
        {
            string query = $"select * from USUARIO";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbClientes.DisplayMember = "Nombre";
            cbClientes.ValueMember = "id";
            cbClientes.DataSource = dt;

        }

        void cbVendedor()
        {
            string query = $"select u.* from USUARIO u inner join VENDEDOR v on v.id_Usuario = u.id";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbVendedores.DisplayMember = "Nombre";
            cbVendedores.ValueMember = "id";
            cbVendedores.DataSource = dt;

        }
        decimal obtenerprecio()
        {
            decimal precio = 0;
            string indice = cbProductos.SelectedValue.ToString();
            string query = $"select Precio from PRODUCTO where id = '{indice}'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                precio = decimal.Parse(rd["Precio"].ToString());
            }
            con.Close();

            return precio;
        }

        void cbMetodos()
        {
            int cliente = int.Parse(cbClientes.SelectedValue.ToString());
            string query = $"select * from METODO_PAGO where id_Usuario = {cliente}";
            SqlCommand cmd = new SqlCommand(query,con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open(); 
            da.Fill(dt);
            con.Close();
            cbMetodo.DisplayMember = "Nombre_Tarjeta";
            cbMetodo.ValueMember = "Tipo";
            cbMetodo.DataSource = dt;
            if (cbMetodo.Items.Count == 0)
            {
                MessageBox.Show("El usuario no cuenta con ningún metodo de pago");
            }
        }
        void cbProducto()
        {
            string query = $"select * from PRODUCTO";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbProductos.DisplayMember = "Nombre";
            cbProductos.ValueMember = "id";
            cbProductos.DataSource = dt;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
                agregar();
                if (dgDetalle.Rows.Count > 0)
                {
                    txtTotal.Text = sumatoria().ToString();
                }
            
        }
        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            txtImporte.Text = Convert.ToString(int.Parse(txtCantidad.Text) * obtenerprecio());

        }

        void guardar()
        { 
            tools t = new tools();
            Venta v = new Venta
            {
                id = int.Parse(txtId.Text),
                id_Usuario = int.Parse(cbClientes.SelectedValue.ToString()),
                id_Vendedor = int.Parse(cbVendedores.SelectedValue.ToString()),
                Estado = 0,
                Fecha = dtpFecha.Value,
                Total = decimal.Parse(txtTotal.Text),
            };
            int cliente = int.Parse(cbClientes.SelectedValue.ToString());
            int tipo = int.Parse(cbMetodo.SelectedValue.ToString());
            string query = $"select * from METODO_PAGO where id_Usuario = {cliente} and Tipo = {tipo}";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                v.id_MetodoPago = int.Parse(rd["id"].ToString());
            }
            con.Close();

            v.guardarventa();
            /*
            2
            4
            5*/
            foreach (DataGridViewRow a in dgDetalle.Rows)
            {
                v.id_Producto = int.Parse(a.Cells[2].Value.ToString());
                v.Cantidad = int.Parse(a.Cells[4].Value.ToString());
                v.Importe = decimal.Parse(a.Cells[5].Value.ToString());
                v.guardardetalle();
            }
        }

        decimal sumatoria()
        {
            decimal total = 0;
            foreach (DataGridViewRow a in dgDetalle.Rows)
            {
                if (a.Cells[5].Value != null)
                {
                    total += decimal.Parse(a.Cells[5].Value.ToString());
                }
            }
            return total;
        }

        private void cbClientes_Leave(object sender, EventArgs e)
        {
            cbMetodos();
        }

        void eliminar()
        {
            string query = $"delete from VENTA where id = {int.Parse(txtId.Text)}";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmBusquedaVenta a = new frmBusquedaVenta();
            a.ShowDialog();
            if (a.DialogResult == DialogResult.OK)
            {
                txtId.Text = a.dsvVenta1.vVenta[a.vVentaBindingSource2.Position].id.ToString();
                dtpFecha.Value = Convert.ToDateTime(a.dsvVenta1.vVenta[a.vVentaBindingSource2.Position].Fecha.ToString());
                cbClientes.SelectedValue = a.dsvVenta1.vVenta[a.vVentaBindingSource2.Position].id_Usuario.ToString();
                cbVendedores.SelectedValue = a.dsvVenta1.vVenta[a.vVentaBindingSource2.Position].id_Vendedor.ToString();
                cbMetodo.SelectedValue = int.Parse(a.dsvVenta1.vVenta[a.vVentaBindingSource2.Position].Tipo_Metodo.ToString());
                txtTotal.Text = "$" + 0;
                dt.Clear();
                dgDetalle.DataSource = dt;
            }
        }

        private void txGuardar_Click(object sender, EventArgs e)
        {
            tools t = new tools();
            if (t.encontrar("VENTA", int.Parse(txtId.Text)))
            {
                eliminar();
                guardar();
                MessageBox.Show("La venta se actualizó correctamente");
                dt.Clear();
                dgDetalle.DataSource = dt;

            }
            else
            {
                guardar();
                MessageBox.Show("La venta se guardó correctamente");
                dgDetalle.DataSource = dt;

            }
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            tools t = new tools();
            dt.Clear();
            dgDetalle.DataSource = dt;
            txtId.Text = t.consecutivo("VENTA").ToString();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            MessageBox.Show("Se eliminó la venta");
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaVenta a = new frmBusquedaVenta();
            a.ShowDialog();
            if (a.DialogResult == DialogResult.OK)
            {
                txtId.Text = a.dsvVenta1.vVenta[a.vVentaBindingSource2.Position].id.ToString();
                dtpFecha.Value = Convert.ToDateTime(a.dsvVenta1.vVenta[a.vVentaBindingSource2.Position].Fecha.ToString());
                cbClientes.SelectedValue = a.dsvVenta1.vVenta[a.vVentaBindingSource2.Position].id_Usuario.ToString();
                cbVendedores.SelectedValue = a.dsvVenta1.vVenta[a.vVentaBindingSource2.Position].id_Vendedor.ToString();
                cbMetodo.SelectedValue = int.Parse(a.dsvVenta1.vVenta[a.vVentaBindingSource2.Position].Tipo_Metodo.ToString());
                txtTotal.Text = "$" + a.dsvVenta1.vVenta[a.vVentaBindingSource2.Position].Total.ToString();
                dgDetalle.DataSource = a.dsvDetalle.vDetalle;
            }
        }
    }
}
