using AZAMON.Clases;
using Microsoft.Reporting.WinForms;
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
    public partial class frmRInventario : Form
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public frmRInventario()
        {
            InitializeComponent();
            con.ConnectionString = Conexion.conexion;
        }

        private void frmRInventario_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            productos();
        }

        void productos()
        {
            DataTable dt = new DataTable();
            string query = "select * from Productos";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbNombre.ValueMember = "id";
            cbNombre.DisplayMember = "Nombre";
            cbNombre.DataSource = dt;
        }
        void cargareporte()
        {
            DataTable dt = new DataTable();
            string query = "";

            if (chTodo.Checked)
            {
                query = "select * from Productos";
                chTodo.Checked = false;
            }
            else
            {
                query = $"select * from Productos where id ={int.Parse(cbNombre.SelectedValue.ToString())}";
            }
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
            con.Close();
            this.rvInventario.LocalReport.DataSources.Clear();
            this.rvInventario.LocalReport.ReportEmbeddedResource = "AZAMON.INFORMES.RInventario.rdlc";
            ReportDataSource r = new ReportDataSource("dsrInventario", dt);
            this.rvInventario.LocalReport.DataSources.Add(r);
            this.rvInventario.RefreshReport();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cargareporte();
        }
    }
}
