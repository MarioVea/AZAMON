using AZAMON.Busquedas;
using AZAMON.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZAMON.formularios
{
    public partial class frmInventario : Form
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        tools t = new tools();
        public frmInventario()
        {
            InitializeComponent();
            con.ConnectionString = Conexion.conexion;
        }
        private void txGuardar_Click(object sender, EventArgs e)
        {
            if (txtExistencia.Text == null)
            {
                MessageBox.Show("Por favor seleccione un producto");
            }
            else
            {
                Inventario i = new Inventario();
                i.id = int.Parse(txtId.Text);
                i.id_Producto = int.Parse(cbProducto.SelectedValue.ToString());
                int cantidad = int.Parse(txtCantidad.Text);
                int existencia = int.Parse(txtExistencia.Text);
                if (cbConcepto.SelectedIndex == 0)
                {
                    if (cantidad < existencia)
                    {
                        i.Existencia = existencia - cantidad;
                        MessageBox.Show(i.guardar());
                    }
                    else MessageBox.Show("No se puede sacar de inventario más de la existencia");
                }
                else
                {
                    i.Existencia = existencia + cantidad; MessageBox.Show(i.guardar());
                }


            }
        }

        void limpiar()
        {
            txtId.Text = t.consecutivo("INVENTARIO").ToString();
            txtCantidad.Text = "0";
            txtExistencia.Text = null;
            cbConcepto.SelectedIndex = 0;
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void llenarproductos()
        {
            DataTable dt = new DataTable();
            string query = $"select id,Nombre from PRODUCTO";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbProducto.DisplayMember = "Nombre";
            cbProducto.ValueMember = "id";
            cbProducto.DataSource = dt;

        }

        void cbconcepto()
        {
            cbConcepto.Items.Add("Salida");
            cbConcepto.Items.Add("Entrada");
            cbConcepto.SelectedIndex = 0;
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            Inventario i = new Inventario();
            i.id = int.Parse(txtId.Text);
            MessageBox.Show(i.eliminar());
            limpiar();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            txtId.Text = t.consecutivo("INVENTARIO").ToString();
            llenarproductos();
            cbconcepto();
        }

        private void cbProducto_Leave(object sender, EventArgs e)
        {
            int producto = int.Parse(cbProducto.SelectedValue.ToString());
            string query = $"select Existencia from INVENTARIO where id_Producto = {producto}";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtExistencia.Text = rd["Existencia"].ToString();
            }
            else txtExistencia.Text = "0";
            con.Close();
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaInventario i = new frmBusquedaInventario();
            i.ShowDialog();
            if (i.DialogResult == DialogResult.OK)
            {
                int a = i.dgProductos.CurrentRow.Index;
                txtId.Text = i.dgProductos.Rows[a].Cells["id"].Value.ToString();
                cbProducto.SelectedValue = int.Parse(i.dgProductos.Rows[a].Cells["id_Producto"].Value.ToString());
                txtExistencia.Text = i.dgProductos.Rows[a].Cells["Existencia"].Value.ToString();

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = $"select * from INVENTARIO where id = {int.Parse(txtId.Text)}";
            SqlCommand cmd = new SqlCommand (query,con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtExistencia.Text = rd["Existencia"].ToString();
                cbProducto.SelectedValue = int.Parse(rd["id_Producto"].ToString());
            }
            con.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmRInventario a = new frmRInventario();
            a.ShowDialog();
        }
    }
}
