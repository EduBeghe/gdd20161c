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
            this.FindForm().ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacion.validarInputs(this.Controls))
            {
                var rolName = (string)rolComboBox.SelectedValue;
                var retornoAlta = new UsuariosRepository().altaUsuario(usernameTextBox.Text, passwordTextBox.Text, rolName);
                if (retornoAlta == 0)
                {
                    MessageBox.Show("El Usuario ha sido creado exitosamente. Por favor complete los siguientes datos");
                    if (rolName.Equals("Cliente"))
                    {
                        new AltaCliente().ShowDialog(usernameTextBox.Text);
                    }
                    else
                    {
                        new AltaEmpresa().ShowDialog(usernameTextBox.Text);
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
            // TODO: esta línea de código carga datos en la tabla 'gD1C2016DataSet5.Roles' Puede moverla o quitarla según sea necesario.
            this.rolesTableAdapter.Fill(this.gD1C2016DataSet5.Roles);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
