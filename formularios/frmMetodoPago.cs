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
    public partial class frmMetodoPago : Form
    {
        tools t = new tools();
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public frmMetodoPago()
        {
            InitializeComponent();
            con.ConnectionString = Conexion.conexion;
        }

        private void frmMetodoPago_Load(object sender, EventArgs e)
        {
            txtId.Text = t.consecutivo("METODO_PAGO").ToString();
            cargarcb();
            cbTipo.SelectedIndex = 0;
            dtpFechVencimiento.Value = DateTime.Now;
        }

        private void txGuardar_Click(object sender, EventArgs e)
        {
            MetodoPago m = new MetodoPago();
            m.id = int.Parse(txtId.Text);
            m.Tipo = int.Parse(cbTipo.SelectedIndex.ToString());
            m.Numero_Tarjeta = txtTarjeta.Text;
            m.CVV = txtCVV.Text;
            m.Fecha_Vencimiento = dtpFechVencimiento.Value;
            m.Titular = txtTitular.Text;
            frmBusquedaUsuario u = new frmBusquedaUsuario();
            u.ShowDialog();
            if (u.DialogResult == DialogResult.OK)
            {
                int i = u.dgUsuarios.CurrentRow.Index;
                m.id_Usuario = int.Parse(u.dgUsuarios.Rows[i].Cells["id"].Value.ToString());
            }
            MessageBox.Show(m.guardar()); limpiar();
        }
        void cargarcb()
        {
            cbTipo.Items.Add("Crédito");
            cbTipo.Items.Add("Débito");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        void limpiar()
        {
            txtId.Text = t.consecutivo("METODO_PAGO").ToString();
            txtCVV.Clear();
            txtTitular.Clear();
            txtTarjeta.Clear();
            cbTipo.SelectedIndex = 0;
            dtpFechVencimiento.Value = DateTime.Now;
            txtTarjeta.Focus();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            MetodoPago m = new MetodoPago
            {
                id = int.Parse(txtId.Text)
            };
            MessageBox.Show(m.eliminar()); limpiar();
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaMetodoPago a = new frmBusquedaMetodoPago();
            a.ShowDialog();
            if (a.DialogResult == DialogResult.OK)
            {
                int i = a.dgMetodos.CurrentRow.Index;
                txtId.Text = a.dgMetodos.Rows[i].Cells["id"].Value.ToString();
                txtTarjeta.Text = a.dgMetodos.Rows[i].Cells["Numero_Tarjeta"].Value.ToString();
                cbTipo.SelectedIndex = int.Parse(a.dgMetodos.Rows[i].Cells["Tipo"].Value.ToString());
                txtCVV.Text = a.dgMetodos.Rows[i].Cells["CVV"].Value.ToString();
                dtpFechVencimiento.Value = Convert.ToDateTime(a.dgMetodos.Rows[i].Cells["Fecha_Vencimiento"].Value.ToString());
                txtTitular.Text = a.dgMetodos.Rows[i].Cells["Titular"].Value.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = $"select * from METODO_PAGO where id = {txtId.Text}";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtTarjeta.Text = rd["Numero_Tarjeta"].ToString();
                cbTipo.SelectedIndex = int.Parse(rd["Tipo"].ToString());
                txtCVV.Text = rd["CVV"].ToString();
                dtpFechVencimiento.Value = Convert.ToDateTime(rd["Fecha_Vencimiento"].ToString());
                txtTitular.Text = rd["Titular"].ToString();
            }
            con.Close();
        }
    }
}
