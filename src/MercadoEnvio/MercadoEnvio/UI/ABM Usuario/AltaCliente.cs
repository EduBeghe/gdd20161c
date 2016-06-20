using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.Utils;
using MercadoEnvio.Repositories;
using MercadoEnvio.Domain;

namespace MercadoEnvio.UI.ABM_Usuario
{
    public partial class AltaCliente : Form
    {
        string username;

        public AltaCliente()
        {
            InitializeComponent();
        }

        internal void ShowDialog(string username)
        {
            this.username = username;
            this.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacion.validarInputs(this.Controls))
            {
                var domicilio = new Domicilio(calleTextBox.Text, Convert.ToInt32(nroPisoTextBox.Text), dptoTextBox.Text, Convert.ToInt32(numeroCalleTextBox.Text), localidadTextBox.Text);
                var retornoAlta = new CLientesRepository.altaCliente(nombreTextBox.Text, apellidoTextBox.Text, Convert.ToInt32(dniTextBox.Text), mailTextBox.Text, Convert.ToInt32(telefonoTextBox.Text), domicilio, Convert.ToInt32(cpTextBox.Text), Convert.ToDateTime(fechaNacTextBox.Text), this.username);
                if (retornoAlta == 0)
                {
                    MessageBox.Show("El cliente ha sido creado exitosamente.");
                }
                else
                {
                    MessageBox.Show("El cliente que quiere dar de alta ya existe.");
                }
            }
        }

    }
}
