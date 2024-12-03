namespace AZAMON.formularios
{
    partial class frmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsLimpiar = new System.Windows.Forms.ToolStripButton();
            this.tsEliminar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbConcepto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(631, 39);
            this.toolStrip1.TabIndex = 15;
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
            this.txGuardar.Click += new System.EventHandler(this.txGuardar_Click);
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
            this.tsBuscar.Click += new System.EventHandler(this.tsBuscar_Click);
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
            this.tsLimpiar.Click += new System.EventHandler(this.tsLimpiar_Click);
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
            this.tsEliminar.Click += new System.EventHandler(this.tsEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(183, 86);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(302, 31);
            this.txtId.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Producto";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Enabled = false;
            this.txtExistencia.Location = new System.Drawing.Point(183, 294);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(302, 31);
            this.txtExistencia.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Existencia";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(356, 336);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 47);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(183, 196);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(302, 31);
            this.txtCantidad.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cantidad";
            // 
            // cbConcepto
            // 
            this.cbConcepto.FormattingEnabled = true;
            this.cbConcepto.Location = new System.Drawing.Point(183, 242);
            this.cbConcepto.Name = "cbConcepto";
            this.cbConcepto.Size = new System.Drawing.Size(302, 37);
            this.cbConcepto.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Concepto";
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(183, 131);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(302, 37);
            this.cbProducto.TabIndex = 27;
            this.cbProducto.Leave += new System.EventHandler(this.cbProducto_Leave);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(631, 454);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbConcepto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInventario";
            this.Text = "frmInventario";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbConcepto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProducto;
    }
}