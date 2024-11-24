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
    }
}
