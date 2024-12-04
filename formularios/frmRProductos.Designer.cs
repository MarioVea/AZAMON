namespace AZAMON.formularios
{
    partial class frmRProductos
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
            this.rvProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chTodo = new System.Windows.Forms.CheckBox();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rvProductos
            // 
            this.rvProductos.LocalReport.ReportEmbeddedResource = "AZAMON.INFORMES.RProductos.rdlc";
            this.rvProductos.Location = new System.Drawing.Point(94, 142);
            this.rvProductos.Name = "rvProductos";
            this.rvProductos.ServerReport.BearerToken = null;
            this.rvProductos.Size = new System.Drawing.Size(942, 448);
            this.rvProductos.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(743, 59);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(159, 39);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chTodo
            // 
            this.chTodo.AutoSize = true;
            this.chTodo.Location = new System.Drawing.Point(286, 69);
            this.chTodo.Name = "chTodo";
            this.chTodo.Size = new System.Drawing.Size(79, 33);
            this.chTodo.TabIndex = 3;
            this.chTodo.Text = "Todo";
            this.chTodo.UseVisualStyleBackColor = true;
            // 
            // cbNombre
            // 
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Location = new System.Drawing.Point(455, 61);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(267, 37);
            this.cbNombre.TabIndex = 4;
            // 
            // frmRProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1100, 815);
            this.Controls.Add(this.cbNombre);
            this.Controls.Add(this.chTodo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.rvProductos);
            this.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmRProductos";
            this.Text = "frmRProductos";
            this.Load += new System.EventHandler(this.frmRProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvProductos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chTodo;
        private System.Windows.Forms.ComboBox cbNombre;
    }
}