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

namespace AZAMON.Busquedas
{
    public partial class frmBusquedaProducto : Form
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public frmBusquedaProducto()
        {
            InitializeComponent();
            con.ConnectionString = Conexion.conexion;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = $"select p.id,p.Nombre as Producto,p.Descripcion,p.Precio,c.Nombre as  Categoria from PRODUCTO p inner join CATEGORIA c on p.id_Categoria = c.id where p.Nombre like '%{txtNombre.Text}%'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            con.Open();
            da.Fill(dt);
            con.Close();
            dgProductos.DataSource = dt;

        }

        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = dgProductos.CurrentRow.Index;
            dgProductos.Rows[a].Selected = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
