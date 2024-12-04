using AZAMON.Busquedas;
using AZAMON.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZAMON.formularios
{
    public partial class frmEntrega : Form
    {
        string query = "";
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        tools t = new tools();
        public frmEntrega()
        {
            InitializeComponent();
            con.ConnectionString = Conexion.conexion;
        }

        private void frmEntrega_Load(object sender, EventArgs e)
        {
            cbVenta();
            cbEstados();
            cbVendedor();
            cbPaqueterias();
            Compradores();
            txtId.Text = t.consecutivo("ENTREGA").ToString();
        }
        void cbVenta()
        {
            query = $"select id from VENTA";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbVentas.DisplayMember = "id";
            cbVentas.ValueMember = "id";
            cbVentas.DataSource = dt;
            query = "";

        }

        void cbPaqueterias()
        {
            query = $"select * from PAQUETERIA";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbPaqueteria.DisplayMember = "Nombre";
            cbPaqueteria.ValueMember = "id";
            cbPaqueteria.DataSource = dt;
            query = "";
        }

        void Compradores()
        {
            query = $"select * from USUARIO";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbComprador.DisplayMember = "Nombre";
            cbComprador.ValueMember = "id";
            cbComprador.DataSource = dt;
            query = "";
        }

        void cbVendedor()
        {
            query = $"select vn.id,u.Nombre from VENDEDOR vn inner join USUARIO u on vn.id = u.id";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbVendedores.DisplayMember = "Nombre";
            cbVendedores.ValueMember = "id";
            cbVendedores.DataSource = dt;
            query = "";
        }
        void cbEstados()
        {
            cbEstado.Items.Add("No entregado");
            cbEstado.Items.Add("Entregado");
        }

        void cbEstadoseleccionado()
        {
            query = $"select Estado from VENTA where id = {int.Parse(cbVentas.SelectedValue.ToString())}";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                cbEstado.SelectedIndex = int.Parse(rd["Estado"].ToString());
            }
            con.Close();
        }

        void datos_venta()
        {
            query = $"select vn.*,u.id as id_usuario from VENTA vn inner join USUARIO u on vn.id_Usuario = u.id where vn.id = {int.Parse(cbVentas.SelectedValue.ToString())}";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                cbComprador.SelectedValue = int.Parse(rd["id_usuario"].ToString());
                cbEstado.SelectedIndex = int.Parse(rd["Estado"].ToString());
                cbVendedores.SelectedValue = int.Parse(rd["id_Vendedor"].ToString());
            }
            con.Close();
            query = "";
        }        

        void obtenerdetalle()
        {
            int vendedor = int.Parse(cbVendedores.SelectedValue.ToString());
            int comprador = int.Parse(cbComprador.SelectedValue.ToString());
            query = $"SELECT v.id_Usuario,v.id_Vendedor,v.id_MetodoPago,v.Estado,v.Fecha,p.Nombre,vd.Cantidad,v.Total FROM VENTA v inner join VENTA_DETALLE vd on vd.id_Venta = v.id inner join PRODUCTO p on vd.id_Producto = p.id where id_Vendedor = {vendedor} and id_Usuario = {comprador}";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
            con.Close();
            dgEntregas.DataSource = dt;

        }
        private void cbVentas_Leave(object sender, EventArgs e)
        {
            datos_venta();
            obtenerdetalle();
            cbEstadoseleccionado();
        }

        private void txtComprador_TextChanged(object sender, EventArgs e)
        {

        }

        void actEstado()
        {
            int venta = int.Parse(cbVentas.SelectedValue.ToString());
            int estado = cbEstado.SelectedIndex;
            query = $"update VENTA set Estado = {estado} where id = {venta}";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void txGuardar_Click(object sender, EventArgs e)
        {
            int paqueteria = int.Parse(cbPaqueteria.SelectedValue.ToString());
            int venta = int.Parse(cbVentas.SelectedValue.ToString());
            Entrega a = new Entrega
            {
                id = int.Parse(txtId.Text),
                id_Venta = venta,
                id_Paqueteria = paqueteria
            };
            actEstado();
            MessageBox.Show(a.guardar()); limpiar();
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaEntrega a = new frmBusquedaEntrega();
            a.ShowDialog();
            if (a.DialogResult == DialogResult.OK)
            {
                int i = a.dgEntregas.CurrentRow.Index;
                txtId.Text = a.dgEntregas.Rows[i].Cells["id_entrega"].Value.ToString();
                cbVentas.SelectedValue = int.Parse(a.dgEntregas.Rows[i].Cells["id_venta"].Value.ToString());
            }
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        void limpiar()
        {
            txtId.Text = t.consecutivo("ENTREGA").ToString();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            Entrega a = new Entrega();
            a.id = int.Parse(txtId.Text);
            MessageBox.Show(a.eliminar());
        }
    }
}
