namespace pryPerez20250507
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbSuperheroe = new System.Windows.Forms.ComboBox();
            this.lblPersonaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbSuperheroe
            // 
            this.cmbSuperheroe.FormattingEnabled = true;
            this.cmbSuperheroe.Location = new System.Drawing.Point(178, 225);
            this.cmbSuperheroe.Name = "cmbSuperheroe";
            this.cmbSuperheroe.Size = new System.Drawing.Size(121, 21);
            this.cmbSuperheroe.TabIndex = 0;
            this.cmbSuperheroe.SelectedIndexChanged += new System.EventHandler(this.cmbSuperheroe_SelectedIndexChanged);
            // 
            // lblPersonaje
            // 
            this.lblPersonaje.AutoSize = true;
            this.lblPersonaje.Location = new System.Drawing.Point(410, 211);
            this.lblPersonaje.Name = "lblPersonaje";
            this.lblPersonaje.Size = new System.Drawing.Size(19, 13);
            this.lblPersonaje.TabIndex = 1;
            this.lblPersonaje.Text = "----";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPersonaje);
            this.Controls.Add(this.cmbSuperheroe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSuperheroe;
        private System.Windows.Forms.Label lblPersonaje;
    }
}

