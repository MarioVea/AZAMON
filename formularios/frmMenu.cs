using AZAMON.Busquedas;
using AZAMON.formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZAMON
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.frmProducto a = new formularios.frmProducto();
            a.ShowDialog();
        }

        private void domiciliosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDomicilio a = new frmDomicilio();
            a.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario a = new frmUsuario();
            a.ShowDialog();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaVendedor a = new frmBusquedaVendedor();
            a.ShowDialog();
        }

        private void metodoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetodoPago a = new frmMetodoPago();
            a.ShowDialog();
        }

        private void paqueteríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaqueteria a = new frmPaqueteria();
            a.ShowDialog();
        }
    }
}
