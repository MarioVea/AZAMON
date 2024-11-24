using AZAMON.Busquedas;
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
    public partial class frmProducto : Form
    {
        tools t = new tools();
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public frmProducto()
        {
            InitializeComponent();
            con.ConnectionString = Conexion.conexion;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            llenarcb();
            txtId.Text = t.consecutivo("PRODUCTO").ToString();
        }

        private void txGuardar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto
            {
                id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Descripcion = rtxtDescripcion.Text,
                id_Categoria = int.Parse(cbCategoria.SelectedValue.ToString()),
                Precio = decimal.Parse(txtPrecio.Text),
            };
            if (t.encontrar("PRODUCTO",int.Parse(txtId.Text)))
            {
                MessageBox.Show(p.actualizar());
            }
            else
            {
                MessageBox.Show(p.guardar());
            }
        }
        void llenarcb()
        {
            DataTable dt = new DataTable();
            string query = $"select * from CATEGORIA";
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "id";
            cbCategoria.DataSource = dt;
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            tools t = new tools();
            Producto p = new Producto
            {
                id = int.Parse(txtId.Text)
            };
            if (t.encontrar("PRODUCTO", int.Parse(txtId.Text)))
            {
                MessageBox.Show(p.eliminar());
                limpiar();
            }
            else MessageBox.Show("No se eliminó el producto con el id especificado ya que no existe");
        }

        void limpiar()
        {
            tools t = new tools();
            txtId.Text = t.consecutivo("PRODUCTO").ToString();
            txtNombre.Clear();
            txtPrecio.Clear();
            rtxtDescripcion.Clear();
            cbCategoria.SelectedIndex = 0;
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaProducto a = new frmBusquedaProducto();
            a.ShowDialog();
            if (a.DialogResult == DialogResult.OK)
            {
                int i = a.dgProductos.CurrentRow.Index;
                txtId.Text = a.dgProductos.Rows[i].Cells["id"].Value.ToString();
                txtNombre.Text = a.dgProductos.Rows[i].Cells["Producto"].Value.ToString();
                rtxtDescripcion.Text = a.dgProductos.Rows[i].Cells["Descripcion"].Value.ToString();
                cbCategoria.SelectedText = a.dgProductos.Rows[i].Cells["Categoria"].Value.ToString();
                txtPrecio.Text = a.dgProductos.Rows[i].Cells["Precio"].Value.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = $"select * from PRODUCTO where id = {txtId.Text}";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtNombre.Text = rd["Nombre"].ToString();
                txtPrecio.Text = rd["Precio"].ToString();
                rtxtDescripcion.Text = rd["Descripcion"].ToString();
                cbCategoria.SelectedValue = rd["id_Categoria"].ToString();
            }
            con.Close();
        }
    }
}
