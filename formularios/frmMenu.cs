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
    }
}
