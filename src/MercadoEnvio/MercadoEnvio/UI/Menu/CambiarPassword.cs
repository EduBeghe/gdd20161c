using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.Domain;
using MercadoEnvio.Utils;
using MercadoEnvio.Repositories;

namespace MercadoEnvio.UI.Menu
{
    public partial class CambiarPassword : Form
    {
        public CambiarPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var passEncriptada = new Encription().encryptToSHA256(passwordTextBox.Text);
            var resultado = new UsuariosRepository().cambiarPassword(passEncriptada);
            if(resultado==0)
            {
                MessageBox.Show("Password cambiada exitosamente.");
            } 
            else
            {
                MessageBox.Show("Hubo un problema y la password no se cambio.");
            }
            this.Close();
        }
    }
}
