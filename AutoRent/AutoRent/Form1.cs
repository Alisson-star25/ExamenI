using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRent
{
    public partial class FrmSolicitud : Form
    {
        public FrmSolicitud()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
                txtNombre.Clear();
                txtDNI.Clear();
                txtTelefono.Clear();
                cmbTipo.SelectedIndex = -1;
        }

        private void btnsig_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || (txtNombre.Text.Length < 3))
            {
                MessageBox.Show("Ingrese el Nombre");
            }
            else if (string.IsNullOrWhiteSpace(txtDNI.Text) || (txtDNI.Text.Length < 13))
            {
                MessageBox.Show("Ingrese el DNI");
            }
            else if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Ingrese el Telefono");
            }
            else if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el Tipo de Vehiculo");
            }
            else
            {
                lblResultado.Text = "Nombre: " + txtNombre.Text + "\nDNI: " + txtDNI.Text +
                    "\nTelefono: " + txtTelefono.Text + "\nTipo de Vehiculo: " + cmbTipo.SelectedItem.ToString();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void pcVehiculo_Click(object sender, EventArgs e)
        {

        }
    }
}
