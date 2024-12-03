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
    public partial class frmBusquedaCategoria : Form
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public frmBusquedaCategoria()
        {
            con.ConnectionString = Conexion.conexion;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = $"select * from CATEGORIA where Nombre like '%{txtNombre.Text}%'"; 
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
            con.Close();
            dgCategorias.DataSource = dt;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
