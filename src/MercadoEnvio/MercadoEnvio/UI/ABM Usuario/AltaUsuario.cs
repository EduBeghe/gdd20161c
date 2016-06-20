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
using MercadoEnvio.UI.ABM_Usuario;

namespace MercadoEnvio.ABM_Usuario
{
    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacion.validarInputs(this.Controls))
            {
                var rolId = new RolesRepository.ObtenerRolIDPorDescripcion(rolComboBox.Text);
                var retornoAlta = new UsuariosRepository.altaUsuario(usernameTextBox.Text, passwordTextBox.Text, rolId);
                if (retornoAlta == 0)
                {
                    MessageBox.Show("El Usuario ha sido creado exitosamente. Por favor complete los siguientes datos");
                    if(rolComboBox.Text.Equals("")){
                        new AltaCliente.ShowDialog(usernameTextBox.Text);
                    }
                    else
                    {
                        new AltaEmpresa.ShowDialog(usernameTextBox.Text);
                    }
                }
                else
                {
                    MessageBox.Show("El Usuario que quiere dar de alta ya existe.");
                }
            }
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
