using AZAMON.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZAMON.Busquedas
{
    public partial class frmBusquedaVenta : Form
    {
        Conexion con = new Conexion();
        public frmBusquedaVenta()
        {
            InitializeComponent();
            vVentaTableAdapter.Connection.ConnectionString = con.conexion;
            vDetalleTableAdapter.Connection.ConnectionString = con.conexion;
        }

        void cargardetalle(int id)
        {
            this.vDetalleTableAdapter.Fill(this.dsvDetalle.vDetalle,id);
        }

        private void frmBusquedaVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsvDetalle.vDetalle' Puede moverla o quitarla según sea necesario.
           // this.vDetalleTableAdapter.Fill(this.dsvDetalle.vDetalle);
            // TODO: esta línea de código carga datos en la tabla 'dsvVenta.vVenta' Puede moverla o quitarla según sea necesario.
            this.vVentaTableAdapter.Fill(this.dsvVenta.vVenta);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            cargardetalle(dsvVenta.vVenta[vVentaBindingSource.Position].id);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
