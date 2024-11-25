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
    public partial class frmBusquedaUsuario : Form
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public frmBusquedaUsuario()
        {
            InitializeComponent();
            con.ConnectionString = Conexion.conexion;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = $"select u.*,d.Calle from USUARIO u inner join DOMICILIO d on u.id_Domicilio = d.id where u.Nombre like '%{txtNombre.Text}%'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
            con.Close();
            dgUsuarios.DataSource = dt;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgUsuarios.CurrentRow.Index;
            dgUsuarios.Rows[i].Selected = true;
        }
    }
}
