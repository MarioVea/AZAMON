using AZAMON.Clases;
using System;
using System.Collections;
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
    public partial class frmBusquedaPaqueteria : Form
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public frmBusquedaPaqueteria()
        {
            con.ConnectionString = Conexion.conexion;
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = $"select * from PAQUETERIA where Nombre like '%{txtNombre.Text}%'";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
            con.Close();
            dgPaqueteria.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        private void dgPaqueteria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgPaqueteria.CurrentRow.Index;
            dgPaqueteria.Rows[i].Selected = true;
        }
    }
}
