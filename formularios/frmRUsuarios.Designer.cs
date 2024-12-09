namespace AZAMON.formularios
{
    partial class frmRUsuarios
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
            this.rvUsuarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.chTodo = new System.Windows.Forms.CheckBox();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rvUsuarios
            // 
            this.rvUsuarios.Location = new System.Drawing.Point(32, 155);
            this.rvUsuarios.Name = "rvUsuarios";
            this.rvUsuarios.ServerReport.BearerToken = null;
            this.rvUsuarios.Size = new System.Drawing.Size(1036, 395);
            this.rvUsuarios.TabIndex = 0;
            // 
            // chTodo
            // 
            this.chTodo.AutoSize = true;
            this.chTodo.Location = new System.Drawing.Point(254, 82);
            this.chTodo.Name = "chTodo";
            this.chTodo.Size = new System.Drawing.Size(79, 33);
            this.chTodo.TabIndex = 1;
            this.chTodo.Text = "Todo";
            this.chTodo.UseVisualStyleBackColor = true;
            // 
            // cbNombre
            // 
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Location = new System.Drawing.Point(415, 82);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(292, 37);
            this.cbNombre.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(770, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(154, 36);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmRUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1100, 816);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbNombre);
            this.Controls.Add(this.chTodo);
            this.Controls.Add(this.rvUsuarios);
            this.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRUsuarios";
            this.Text = "frmRUsuarios";
            this.Load += new System.EventHandler(this.frmRUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvUsuarios;
        private System.Windows.Forms.CheckBox chTodo;
        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.Button btnBuscar;
    }
}