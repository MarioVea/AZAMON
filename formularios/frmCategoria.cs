using AZAMON.Busquedas;
using AZAMON.Clases;
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
    public partial class frmCategoria : Form
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        tools t = new tools();

        public frmCategoria()
        {
            InitializeComponent();
            con.ConnectionString = Conexion.conexion;
        }

        private void txGuardar_Click(object sender, EventArgs e)
        {
            Categoria c = new Categoria
            {
                id = int.Parse(txtId.Text),
                Nombre = txtCategoria.Text,
            };
            MessageBox.Show(c.guardar()); limpiar();
        }
        void limpiar()
        {
            txtId.Text = t.consecutivo("CATEGORIA").ToString();
            txtCategoria.Clear();
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            Categoria c = new Categoria();
            c.id = int.Parse(txtId.Text);
            MessageBox.Show(c.eliminar());
            limpiar();
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaCategoria a = new frmBusquedaCategoria();
            a.ShowDialog();
            if (a.DialogResult == DialogResult.OK)
            {
                int i = a.dgCategorias.CurrentRow.Index;
                txtId.Text = a.dgCategorias.Rows[i].Cells["id"].Value.ToString();
                txtCategoria.Text = a.dgCategorias.Rows[i].Cells["Nombre"].Value.ToString();
            }
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            txtId.Text = t.consecutivo("CATEGORIA").ToString();
        }
    }
}
