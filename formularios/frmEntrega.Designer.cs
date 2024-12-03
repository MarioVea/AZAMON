namespace AZAMON.formularios
{
    partial class frmEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntrega));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsLimpiar = new System.Windows.Forms.ToolStripButton();
            this.tsEliminar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbPaqueteria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComprador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbVenta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txGuardar,
            this.tsBuscar,
            this.tsLimpiar,
            this.tsEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1100, 39);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txGuardar
            // 
            this.txGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.txGuardar.Image = ((System.Drawing.Image)(resources.GetObject("txGuardar.Image")));
            this.txGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.txGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txGuardar.Name = "txGuardar";
            this.txGuardar.Size = new System.Drawing.Size(36, 36);
            this.txGuardar.Text = "Guardar";
            // 
            // tsBuscar
            // 
            this.tsBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsBuscar.Image")));
            this.tsBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBuscar.Name = "tsBuscar";
            this.tsBuscar.Size = new System.Drawing.Size(36, 36);
            this.tsBuscar.Text = "Buscar";
            // 
            // tsLimpiar
            // 
            this.tsLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("tsLimpiar.Image")));
            this.tsLimpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLimpiar.Name = "tsLimpiar";
            this.tsLimpiar.Size = new System.Drawing.Size(36, 36);
            this.tsLimpiar.Text = "Limpiar";
            // 
            // tsEliminar
            // 
            this.tsEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsEliminar.Image")));
            this.tsEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEliminar.Name = "tsEliminar";
            this.tsEliminar.Size = new System.Drawing.Size(36, 36);
            this.tsEliminar.Text = "Eliminar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(196, 92);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 31);
            this.txtId.TabIndex = 18;
            // 
            // cbPaqueteria
            // 
            this.cbPaqueteria.FormattingEnabled = true;
            this.cbPaqueteria.Location = new System.Drawing.Point(481, 87);
            this.cbPaqueteria.Name = "cbPaqueteria";
            this.cbPaqueteria.Size = new System.Drawing.Size(121, 37);
            this.cbPaqueteria.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Paquetería";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(995, 281);
            this.dataGridView1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "IdVenta";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Enabled = false;
            this.txtVendedor.Location = new System.Drawing.Point(196, 155);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(100, 31);
            this.txtVendedor.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Vendedor";
            // 
            // txtComprador
            // 
            this.txtComprador.Enabled = false;
            this.txtComprador.Location = new System.Drawing.Point(502, 154);
            this.txtComprador.Name = "txtComprador";
            this.txtComprador.Size = new System.Drawing.Size(100, 31);
            this.txtComprador.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Comprador";
            // 
            // cbVenta
            // 
            this.cbVenta.FormattingEnabled = true;
            this.cbVenta.Location = new System.Drawing.Point(728, 86);
            this.cbVenta.Name = "cbVenta";
            this.cbVenta.Size = new System.Drawing.Size(121, 37);
            this.cbVenta.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(622, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(728, 148);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 37);
            this.cbEstado.TabIndex = 29;
            // 
            // frmEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1100, 816);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbVenta);
            this.Controls.Add(this.txtComprador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPaqueteria);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEntrega";
            this.Text = "frmEntrega";
            this.Load += new System.EventHandler(this.frmEntrega_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton txGuardar;
        private System.Windows.Forms.ToolStripButton tsBuscar;
        private System.Windows.Forms.ToolStripButton tsLimpiar;
        private System.Windows.Forms.ToolStripButton tsEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbPaqueteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComprador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEstado;
    }
}