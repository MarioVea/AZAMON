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
    public partial class frmBusquedaInventario : Form
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public frmBusquedaInventario()
        {
            InitializeComponent();
            con.ConnectionString = Conexion.conexion;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string query = $"select i.*,p.Nombre from INVENTARIO i inner join PRODUCTO p on p.id = I.id_Producto where p.Nombre like '%{txtNombre.Text}%'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
            con.Close();
            dgProductos.DataSource = dt;
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
