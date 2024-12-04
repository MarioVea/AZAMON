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
    public partial class frmBusquedaEntrega : Form
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();

        public frmBusquedaEntrega()
        {
            InitializeComponent();
            con.ConnectionString = Conexion.conexion;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = $"select e.id as id_entrega,v.id as id_venta,p.Nombre,u.Nombre as Comprador,v.Total from ENTREGA e inner join PAQUETERIA p on p.id = e.id_Paqueteria inner join VENTA v on e.id_Venta = v.id inner join USUARIO u on u.id = v.id_Usuario where p.Nombre like '%{txtNombre.Text}%'";

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
            con.Close();
            dgEntregas.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
