﻿using AZAMON.Clases;
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
            cbMetodo.Items.Add("Crédito");
            cbMetodo.Items.Add("Débito");
            cbMetodo.SelectedIndex = 0;
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
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            txtImporte.Text = Convert.ToString(int.Parse(txtCantidad.Text) * obtenerprecio());
        }
    }
}