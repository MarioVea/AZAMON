using AZAMON.Clases;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZAMON.formularios
{
    public partial class frmRUsuarios : Form
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public frmRUsuarios()
        {
            InitializeComponent();
            con.ConnectionString = Conexion.conexion;
        }

        private void frmRUsuarios_Load(object sender, EventArgs e)
        {

            this.rvUsuarios.RefreshReport();
            Usuarios();
        }

        void Usuarios()
        {
            DataTable dt = new DataTable();
            string query = "select * from USUARIO";
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
                query = "select * from vUsuarios";
                chTodo.Checked = false;
            }
            else
            {
                query = $"select * from vUsuarios where id = {int.Parse(cbNombre.SelectedValue.ToString())}";
            }
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
            con.Close();
            this.rvUsuarios.LocalReport.DataSources.Clear();
            this.rvUsuarios.LocalReport.ReportEmbeddedResource = "AZAMON.INFORMES.RUsuarios.rdlc";
            ReportDataSource r = new ReportDataSource("dsrUsuarios", dt);
            this.rvUsuarios.LocalReport.DataSources.Add(r);
            this.rvUsuarios.RefreshReport();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargareporte();
        }
    }
}
