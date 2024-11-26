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
    public partial class frmBusquedaVendedor : Form
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public frmBusquedaVendedor()
        {
            InitializeComponent();
            con.ConnectionString = Conexion.conexion;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = $"select u.Nombre,u.A_Paterno,u.A_Materno from USUARIO u inner join VENDEDOR v on u.id = v.id_Usuario where u.Nombre like '%{txtNombre.Text}%'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
            con.Close();
            dgVendedores.DataSource = dt;
        }
    }
}
