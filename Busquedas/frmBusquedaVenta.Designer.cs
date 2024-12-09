namespace AZAMON.Busquedas
{
    partial class frmBusquedaVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.vVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsvVenta = new AZAMON.dsvVenta();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsvDetalle = new AZAMON.dsvDetalle();
            this.vVentaTableAdapter = new AZAMON.dsvVentaTableAdapters.vVentaTableAdapter();
            this.vDetalleTableAdapter = new AZAMON.dsvDetalleTableAdapters.vDetalleTableAdapter();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dsvVentas = new AZAMON.dsvVentas();
            this.vVentaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vVentaTableAdapter1 = new AZAMON.dsvVentasTableAdapters.vVentaTableAdapter();
            this.vVentaTableAdapter2 = new AZAMON.AZAMONDataSetTableAdapters.vVentaTableAdapter();
            this.azamonDataSet1 = new AZAMON.AZAMONDataSet();
            this.azamonDataSet2 = new AZAMON.AZAMONDataSet();
            this.azamonDataSet3 = new AZAMON.AZAMONDataSet();
            this.dsvVenta1 = new AZAMON.dsvVenta1();
            this.vVentaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vVentaTableAdapter3 = new AZAMON.dsvVenta1TableAdapters.vVentaTableAdapter();
            this.dgVenta = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMetodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTarjetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsvVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVentaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azamonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azamonDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azamonDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsvVenta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVentaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // vVentaBindingSource
            // 
            this.vVentaBindingSource.DataMember = "vVenta";
            this.vVentaBindingSource.DataSource = this.dsvVenta;
            // 
            // dsvVenta
            // 
            this.dsvVenta.DataSetName = "dsvVenta";
            this.dsvVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.idVentaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn1,
            this.cantidadDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.vDetalleBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(109, 346);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(912, 201);
            this.dataGridView2.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // idVentaDataGridViewTextBoxColumn
            // 
            this.idVentaDataGridViewTextBoxColumn.DataPropertyName = "id_Venta";
            this.idVentaDataGridViewTextBoxColumn.HeaderText = "id_Venta";
            this.idVentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idVentaDataGridViewTextBoxColumn.Name = "idVentaDataGridViewTextBoxColumn";
            this.idVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVentaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "Importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.importeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            this.importeDataGridViewTextBoxColumn.ReadOnly = true;
            this.importeDataGridViewTextBoxColumn.Width = 125;
            // 
            // vDetalleBindingSource
            // 
            this.vDetalleBindingSource.DataMember = "vDetalle";
            this.vDetalleBindingSource.DataSource = this.dsvDetalle;
            // 
            // dsvDetalle
            // 
            this.dsvDetalle.DataSetName = "dsvDetalle";
            this.dsvDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vVentaTableAdapter
            // 
            this.vVentaTableAdapter.ClearBeforeFill = true;
            // 
            // vDetalleTableAdapter
            // 
            this.vDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(806, 597);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(95, 50);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(923, 597);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 50);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dsvVentas
            // 
            this.dsvVentas.DataSetName = "dsvVentas";
            this.dsvVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vVentaBindingSource1
            // 
            this.vVentaBindingSource1.DataMember = "vVenta";
            this.vVentaBindingSource1.DataSource = this.dsvVentas;
            // 
            // vVentaTableAdapter1
            // 
            this.vVentaTableAdapter1.ClearBeforeFill = true;
            // 
            // vVentaTableAdapter2
            // 
            this.vVentaTableAdapter2.ClearBeforeFill = true;
            // 
            // azamonDataSet1
            // 
            this.azamonDataSet1.DataSetName = "AZAMONDataSet";
            this.azamonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // azamonDataSet2
            // 
            this.azamonDataSet2.DataSetName = "AZAMONDataSet";
            this.azamonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // azamonDataSet3
            // 
            this.azamonDataSet3.DataSetName = "AZAMONDataSet";
            this.azamonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsvVenta1
            // 
            this.dsvVenta1.DataSetName = "dsvVenta1";
            this.dsvVenta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vVentaBindingSource2
            // 
            this.vVentaBindingSource2.DataMember = "vVenta";
            this.vVentaBindingSource2.DataSource = this.dsvVenta1;
            // 
            // vVentaTableAdapter3
            // 
            this.vVentaTableAdapter3.ClearBeforeFill = true;
            // 
            // dgVenta
            // 
            this.dgVenta.AllowUserToAddRows = false;
            this.dgVenta.AllowUserToDeleteRows = false;
            this.dgVenta.AutoGenerateColumns = false;
            this.dgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.tipoMetodoDataGridViewTextBoxColumn,
            this.nombreTarjetaDataGridViewTextBoxColumn,
            this.idVendedorDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgVenta.DataSource = this.vVentaBindingSource2;
            this.dgVenta.Location = new System.Drawing.Point(109, 35);
            this.dgVenta.Name = "dgVenta";
            this.dgVenta.ReadOnly = true;
            this.dgVenta.RowHeadersWidth = 51;
            this.dgVenta.RowTemplate.Height = 24;
            this.dgVenta.Size = new System.Drawing.Size(912, 255);
            this.dgVenta.TabIndex = 4;
            this.dgVenta.SelectionChanged += new System.EventHandler(this.dgVenta_SelectionChanged_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "id_Usuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "id_Usuario";
            this.idUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoMetodoDataGridViewTextBoxColumn
            // 
            this.tipoMetodoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Metodo";
            this.tipoMetodoDataGridViewTextBoxColumn.HeaderText = "Tipo_Metodo";
            this.tipoMetodoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoMetodoDataGridViewTextBoxColumn.Name = "tipoMetodoDataGridViewTextBoxColumn";
            this.tipoMetodoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoMetodoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreTarjetaDataGridViewTextBoxColumn
            // 
            this.nombreTarjetaDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Tarjeta";
            this.nombreTarjetaDataGridViewTextBoxColumn.HeaderText = "Nombre_Tarjeta";
            this.nombreTarjetaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreTarjetaDataGridViewTextBoxColumn.Name = "nombreTarjetaDataGridViewTextBoxColumn";
            this.nombreTarjetaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreTarjetaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idVendedorDataGridViewTextBoxColumn
            // 
            this.idVendedorDataGridViewTextBoxColumn.DataPropertyName = "id_Vendedor";
            this.idVendedorDataGridViewTextBoxColumn.HeaderText = "id_Vendedor";
            this.idVendedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idVendedorDataGridViewTextBoxColumn.Name = "idVendedorDataGridViewTextBoxColumn";
            this.idVendedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVendedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmBusquedaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1100, 816);
            this.Controls.Add(this.dgVenta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBusquedaVenta";
            this.Text = "frmBusquedaVenta";
            this.Load += new System.EventHandler(this.frmBusquedaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsvVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVentaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azamonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azamonDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azamonDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsvVenta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVentaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView2;
        public dsvVenta dsvVenta;
        public System.Windows.Forms.BindingSource vVentaBindingSource;
        public dsvVentaTableAdapters.vVentaTableAdapter vVentaTableAdapter;
        public dsvDetalle dsvDetalle;
        public System.Windows.Forms.BindingSource vDetalleBindingSource;
        public dsvDetalleTableAdapters.vDetalleTableAdapter vDetalleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private dsvVentas dsvVentas;
        private System.Windows.Forms.BindingSource vVentaBindingSource1;
        private dsvVentasTableAdapters.vVentaTableAdapter vVentaTableAdapter1;
        private AZAMONDataSetTableAdapters.vVentaTableAdapter vVentaTableAdapter2;
        private AZAMONDataSet azamonDataSet1;
        private AZAMONDataSet azamonDataSet2;
        private AZAMONDataSet azamonDataSet3;   
        public dsvVenta1 dsvVenta1;
        public System.Windows.Forms.BindingSource vVentaBindingSource2;
        private dsvVenta1TableAdapters.vVentaTableAdapter vVentaTableAdapter3;
        public System.Windows.Forms.DataGridView dgVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMetodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTarjetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}