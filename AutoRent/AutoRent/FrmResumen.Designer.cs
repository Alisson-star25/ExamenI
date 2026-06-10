namespace AutoRent
{
    partial class FrmResumen
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
            this.lblTel = new System.Windows.Forms.Label();
            this.lblDNII = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(48, 195);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(110, 29);
            this.lblTel.TabIndex = 11;
            this.lblTel.Text = "Telefono";
            // 
            // lblDNII
            // 
            this.lblDNII.AutoSize = true;
            this.lblDNII.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNII.Location = new System.Drawing.Point(48, 138);
            this.lblDNII.Name = "lblDNII";
            this.lblDNII.Size = new System.Drawing.Size(54, 29);
            this.lblDNII.TabIndex = 9;
            this.lblDNII.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(48, 84);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(223, 29);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre del Cliente";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(48, 250);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(196, 29);
            this.lblVehiculo.TabIndex = 12;
            this.lblVehiculo.Text = "Tipo de Vehiculo";
            // 
            // FrmResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblDNII);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmResumen";
            this.Text = "Resumen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblDNII;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblVehiculo;
    }
}