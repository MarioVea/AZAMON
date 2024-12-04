namespace AZAMON.formularios
{
    partial class frmRInventario
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
            this.rvInventario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.chTodo = new System.Windows.Forms.CheckBox();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rvInventario
            // 
            this.rvInventario.LocalReport.ReportEmbeddedResource = "AZAMON.INFORMES.RInventario.rdlc";
            this.rvInventario.Location = new System.Drawing.Point(153, 123);
            this.rvInventario.Name = "rvInventario";
            this.rvInventario.ServerReport.BearerToken = null;
            this.rvInventario.Size = new System.Drawing.Size(752, 396);
            this.rvInventario.TabIndex = 0;
            // 
            // chTodo
            // 
            this.chTodo.AutoSize = true;
            this.chTodo.Location = new System.Drawing.Point(261, 64);
            this.chTodo.Name = "chTodo";
            this.chTodo.Size = new System.Drawing.Size(79, 33);
            this.chTodo.TabIndex = 1;
            this.chTodo.Text = "Todo";
            this.chTodo.UseVisualStyleBackColor = true;
            // 
            // cbNombre
            // 
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Location = new System.Drawing.Point(382, 58);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(236, 37);
            this.cbNombre.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(655, 51);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(143, 44);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmRInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1100, 816);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbNombre);
            this.Controls.Add(this.chTodo);
            this.Controls.Add(this.rvInventario);
            this.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRInventario";
            this.Text = "frmRInventario";
            this.Load += new System.EventHandler(this.frmRInventario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvInventario;
        private System.Windows.Forms.CheckBox chTodo;
        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.Button btnAceptar;
    }
}