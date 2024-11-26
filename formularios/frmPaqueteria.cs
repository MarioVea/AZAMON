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
    public partial class frmPaqueteria : Form
    {
        tools t = new tools();
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public frmPaqueteria()
        {
            InitializeComponent();
            con.ConnectionString = Conexion.conexion;
        }

        private void txGuardar_Click(object sender, EventArgs e)
        {
            Paqueteria p = new Paqueteria
            {
                id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text
            };

            MessageBox.Show(p.guardar()); limpiar();
        }
        void limpiar()
        {
            txtId.Text = t.consecutivo("PAQUETERIA").ToString();
            txtNombre.Clear();
            txtNombre.Focus();
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            Paqueteria p = new Paqueteria
            {
                id = int.Parse(txtId.Text)
            };
            MessageBox.Show(p.eliminar()); limpiar();
        }

        private void frmPaqueteria_Load(object sender, EventArgs e)
        {
            txtId.Text = t.consecutivo("PAQUETERIA").ToString();
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaPaqueteria a = new frmBusquedaPaqueteria();
            a.ShowDialog();
            if (a.DialogResult == DialogResult.OK)
            {
                int i = a.dgPaqueteria.CurrentRow.Index;
                txtId.Text = a.dgPaqueteria.Rows[i].Cells["id"].Value.ToString();
                txtNombre.Text = a.dgPaqueteria.Rows[i].Cells["Nombre"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"select * from PAQUETERIA where id = {int.Parse(txtId.Text)}";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtId.Text = rd["id"].ToString();
                txtNombre.Text = rd["Nombre"].ToString();
            }
            con.Close();
        }
    }
}
