namespace CapaVista_MVC4
{
    partial class frmPrincipal
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
            this.btnConsultarCiudad = new System.Windows.Forms.Button();
            this.dgvConsultarTabla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarCiudad
            // 
            this.btnConsultarCiudad.Location = new System.Drawing.Point(263, 23);
            this.btnConsultarCiudad.Name = "btnConsultarCiudad";
            this.btnConsultarCiudad.Size = new System.Drawing.Size(162, 93);
            this.btnConsultarCiudad.TabIndex = 0;
            this.btnConsultarCiudad.Text = "Consultar Ciudad";
            this.btnConsultarCiudad.UseVisualStyleBackColor = true;
            this.btnConsultarCiudad.Click += new System.EventHandler(this.btnConsultarCiudad_Click);
            // 
            // dgvConsultarTabla
            // 
            this.dgvConsultarTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarTabla.Location = new System.Drawing.Point(94, 155);
            this.dgvConsultarTabla.Name = "dgvConsultarTabla";
            this.dgvConsultarTabla.RowHeadersWidth = 51;
            this.dgvConsultarTabla.RowTemplate.Height = 24;
            this.dgvConsultarTabla.Size = new System.Drawing.Size(624, 150);
            this.dgvConsultarTabla.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvConsultarTabla);
            this.Controls.Add(this.btnConsultarCiudad);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarCiudad;
        private System.Windows.Forms.DataGridView dgvConsultarTabla;
    }
}