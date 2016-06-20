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
    public partial class AltaEmpresa : Form
    {
        string username;

        public AltaEmpresa()
        {
            InitializeComponent();
        }

        internal void ShowDialog(string username)
        {
            this.username = username;
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacion.validarInputs(this.Controls))
            {
                var domicilio = new Domicilio(calleTextBox.Text,Convert.ToInt32(numeroPisoTextBox.Text), dptoTextBox.Text, Convert.ToInt32(numeroCalleTextBox.Text), localidadTextBox.Text);
                var detalle = new DetalleEmpresa(razonTextBox.Text,mailTextBox.Text,Convert.ToInt32(telefonoTextBox.Text), domicilio, cpTextBox.Text, ciudadTextBox.Text, cuitTextBox.Text, true, this.username);
                var retornoAlta = new EmpresaRepository.altaEmpresa(detalle);
                if (retornoAlta == 0)
                {
                    MessageBox.Show("La empresa ha sido creada exitosamente.");
                }
                else
                {
                    MessageBox.Show("La empresa que quiere dar de alta ya existe.");
                }
            }
        }

        private void AltaEmpresa_Load(object sender, EventArgs e)
        {

        }
    }
}
