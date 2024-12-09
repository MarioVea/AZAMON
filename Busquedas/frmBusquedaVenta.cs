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
            // TODO: esta línea de código carga datos en la tabla 'dsvVenta1.vVenta' Puede moverla o quitarla según sea necesario.
            this.vVentaTableAdapter3.Fill(this.dsvVenta1.vVenta);
            // TODO: esta línea de código carga datos en la tabla 'aZAMONDataSet.vVenta' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'dsvVentas.vVenta' Puede moverla o quitarla según sea necesario.
            this.vVentaTableAdapter1.Fill(this.dsvVentas.vVenta);
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

        private void dgVenta_SelectionChanged_1(object sender, EventArgs e)
        {
            cargardetalle(dsvVenta1.vVenta[vVentaBindingSource2.Position].id);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
