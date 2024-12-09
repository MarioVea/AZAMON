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
    public partial class frmUsuario : Form
    {
        tools t = new tools();
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public frmUsuario()
        {
            InitializeComponent(); 
            con.ConnectionString = Conexion.conexion;

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            txtId.Text = t.consecutivo("USUARIO").ToString();
        }

        private void txGuardar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.id = int.Parse(txtId.Text);
            u.Nombre = txtNombre.Text;
            u.A_Paterno = txtAPaterno.Text;
            u.A_Materno = txtAMaterno.Text;
            u.Edad = int.Parse(txtEdad.Text);
            u.Email = txtEmail.Text;
            u.Telefono = txtTelefono.Text;
            u.Contrasena = txtContrasena.Text;
            frmBusquedaDomicilio a = new frmBusquedaDomicilio();
            a.ShowDialog();
            if (a.DialogResult == DialogResult.OK)
            {
                int i = a.dgDomicilios.CurrentRow.Index;
                u.id_Domicilio = int.Parse(a.dgDomicilios.Rows[i].Cells["id"].Value.ToString());
            }
            MessageBox.Show(u.guardar());
            registrarvendedor();
            limpiar();
        }

        void registrarvendedor()
        {
            if (chbvendedor.Checked && (t.encontrar("USUARIO",int.Parse(txtId.Text))))
            {
                txtRFC.ReadOnly = true;
                string query = $"insert into VENDEDOR values({t.consecutivo("VENDEDOR")},{int.Parse(txtId.Text)},'{txtRFC.Text}')";
                SqlCommand cmd = new SqlCommand(query,con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            else if (chbvendedor.Checked == false)
            {
                txtRFC.ReadOnly = false;
            }
        }

        void limpiar()
        {
            txtId.Text = t.consecutivo("USUARIO").ToString();
            txtNombre.Clear();
            txtAPaterno.Clear();
            txtAMaterno.Clear();
            txtEdad.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtContrasena.Clear();
            txtNombre.Focus();
        }
        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.id = int.Parse(txtId.Text);
            MessageBox.Show(u.eliminar());
            limpiar();
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaUsuario a = new frmBusquedaUsuario();
            a.ShowDialog();
            if(a.DialogResult == DialogResult.OK)
            {   
                int i = a.dgUsuarios.CurrentRow.Index;
                txtId.Text = a.dgUsuarios.Rows[i].Cells["id"].Value.ToString();
                txtNombre.Text = a.dgUsuarios.Rows[i].Cells["Nombre"].Value.ToString();
                txtAPaterno.Text = a.dgUsuarios.Rows[i].Cells["A_Paterno"].Value.ToString();
                txtAMaterno.Text = a.dgUsuarios.Rows[i].Cells["A_Materno"].Value.ToString();
                txtEdad.Text = a.dgUsuarios.Rows[i].Cells["Edad"].Value.ToString();
                txtEmail.Text = a.dgUsuarios.Rows[i].Cells["Email"].Value.ToString();
                txtContrasena.Text = a.dgUsuarios.Rows[i].Cells["Contrasena"].Value.ToString();
                txtTelefono.Text = a.dgUsuarios.Rows[i].Cells["Telefono"].Value.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = $"select * from USUARIO where id ={int.Parse(txtId.Text)}";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtId.Text = rd["id"].ToString();
                txtNombre.Text = rd["Nombre"].ToString();
                txtAPaterno.Text = rd["A_Paterno"].ToString();
                txtAMaterno.Text = rd["A_Materno"].ToString();
                txtEdad.Text = rd["Edad"].ToString();
                txtEmail.Text = rd["Email"].ToString();
                txtContrasena.Text = rd["Contrasena"].ToString();
                txtTelefono.Text = rd["Telefono"].ToString();
            }
            con.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmRUsuarios a = new frmRUsuarios();
            a.ShowDialog();
        }

        private void chbvendedor_Leave(object sender, EventArgs e)
        {
            if (chbvendedor.Checked)
            {
                txtRFC.Enabled = true;
            }
            else txtRFC.Enabled = false;
        }

        private void chbvendedor_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
