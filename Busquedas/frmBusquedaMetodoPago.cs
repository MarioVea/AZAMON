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
    public partial class frmBusquedaMetodoPago : Form
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public frmBusquedaMetodoPago()
        {
            InitializeComponent();
            con.ConnectionString = Conexion.conexion;
        }

        private void frmBusquedaMetodoPago_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = $"select m.id,(u.Nombre + ' ' + u.A_Paterno + ' ' + A_Materno) Nombre,m.Tipo,m.Numero_Tarjeta,m.CVV,m.Fecha_Vencimiento,m.Titular from METODO_PAGO m inner join USUARIO u on m.id_Usuario = u.id where u.Nombre like '%{txtNombre.Text}%'";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
            con.Close();
            dgMetodos.DataSource = dt;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
        }

        private void dgMetodos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgMetodos.CurrentRow.Index;
            dgMetodos.Rows[i].Selected = true;
        }
    }
}
