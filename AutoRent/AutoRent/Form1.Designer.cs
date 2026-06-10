namespace AutoRent
{
    partial class FrmSolicitud
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
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.pcVehiculo = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnsig = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquiler.Location = new System.Drawing.Point(12, 23);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(366, 55);
            this.lblAlquiler.TabIndex = 0;
            this.lblAlquiler.Text = "Alquiler de Autos";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(17, 92);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(235, 29);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Nombre del Cliente: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(259, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(269, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(17, 146);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(60, 29);
            this.lblDNI.TabIndex = 3;
            this.lblDNI.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(259, 153);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(269, 22);
            this.txtDNI.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(17, 203);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(116, 29);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(259, 210);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(269, 22);
            this.txtTelefono.TabIndex = 6;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Turismo",
            "SUV",
            "Pickup"});
            this.cmbTipo.Location = new System.Drawing.Point(259, 277);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(269, 24);
            this.cmbTipo.TabIndex = 7;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(17, 277);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(202, 29);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo de Vehiculo:";
            // 
            // pcVehiculo
            // 
            this.pcVehiculo.Location = new System.Drawing.Point(259, 319);
            this.pcVehiculo.Name = "pcVehiculo";
            this.pcVehiculo.Size = new System.Drawing.Size(269, 109);
            this.pcVehiculo.TabIndex = 9;
            this.pcVehiculo.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(598, 92);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(173, 83);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnsig
            // 
            this.btnsig.Location = new System.Drawing.Point(598, 203);
            this.btnsig.Name = "btnsig";
            this.btnsig.Size = new System.Drawing.Size(173, 83);
            this.btnsig.TabIndex = 11;
            this.btnsig.Text = "Siguiente";
            this.btnsig.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(598, 319);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(173, 83);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(818, 488);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnsig);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pcVehiculo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblAlquiler);
            this.Name = "FrmSolicitud";
            this.Text = "AutoRent HN";
            ((System.ComponentModel.ISupportInitialize)(this.pcVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.PictureBox pcVehiculo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnsig;
        private System.Windows.Forms.Button btnCerrar;
    }
}

