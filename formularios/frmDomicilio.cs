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
    public partial class frmDomicilio : Form
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public frmDomicilio()
        {
            InitializeComponent();
            con.ConnectionString = Conexion.conexion;
        }

        private void txGuardar_Click(object sender, EventArgs e)
        {
            tools t = new tools();
            Domicilio d = new Domicilio
            {
                id = int.Parse(txtId.Text),
                Calle = txtCalle.Text,
                No_Exterior = int.Parse(txtNumeroExterior.Text),
                No_Interior = int.Parse(txtNumeroInterior.Text),
                Colonia = txtColonia.Text,
                Referencias = rtxtReferencias.Text,
                CP = txtCP.Text
            };

            if (t.encontrar("DOMICILIO", int.Parse(txtId.Text)))
            {
                MessageBox.Show(d.actualizar());
                limpiar();
            }
            else MessageBox.Show(d.guardar()); limpiar();
        }

        private void frmDomicilio_Load(object sender, EventArgs e)
        {
            tools t = new tools();
            txtId.Text = t.consecutivo("DOMICILIO").ToString();

        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();

        }
        void limpiar()
        {
            tools t = new tools();
            txtId.Text = t.consecutivo("DOMICILIO").ToString();
            txtCalle.Clear();
            txtNumeroExterior.Clear();
            txtNumeroInterior.Clear();
            txtColonia.Clear();
            txtCP.Clear();
            rtxtReferencias.Clear();
            txtCalle.Focus();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            Domicilio d = new Domicilio
            {
                id = int.Parse(txtId.Text)
            };
            MessageBox.Show(d.eliminar()); limpiar();
            
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
           frmBusquedaDomicilio a = new frmBusquedaDomicilio();
            a.ShowDialog();
            if (a.DialogResult == DialogResult.OK)
            {
                int i = a.dgDomicilios.CurrentRow.Index;
                txtId.Text = a.dgDomicilios.Rows[i].Cells["id"].Value.ToString();
                txtCalle.Text = a.dgDomicilios.Rows[i].Cells["Calle"].Value.ToString();
                txtColonia.Text = a.dgDomicilios.Rows[i].Cells["Colonia"].Value.ToString();
                txtNumeroExterior.Text = a.dgDomicilios.Rows[i].Cells["No_Exterior"].Value.ToString();
                txtNumeroInterior.Text = a.dgDomicilios.Rows[i].Cells["No_Interior"].Value.ToString();
                rtxtReferencias.Text = a.dgDomicilios.Rows[i].Cells["Referencias"].Value.ToString();
                txtCP.Text = a.dgDomicilios.Rows[i].Cells["CP"].Value.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = $"select * from DOMICILIO where id = {int.Parse(txtId.Text)}";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            SqlDataReader rd =cmd.ExecuteReader();
            if (rd.Read())
            {
                txtId.Text = rd["id"].ToString();
                txtCalle.Text = rd["Calle"].ToString();
                txtColonia.Text = rd["Colonia"].ToString();
                txtNumeroExterior.Text = rd["No_Exterior"].ToString();
                txtNumeroInterior.Text = rd["No_Interior"].ToString();
                rtxtReferencias.Text = rd["Referencias"].ToString();
                txtCP.Text = rd["CP"].ToString();
            }
            con.Close();
        }
    }
}
