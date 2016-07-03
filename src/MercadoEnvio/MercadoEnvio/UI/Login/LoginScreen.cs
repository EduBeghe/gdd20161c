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
using MercadoEnvio.UI.Menu;

namespace MercadoEnvio.UI.Login
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.FindForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var repo = new UsuariosRepository();
            if (Validacion.validarInputs(this.Controls))
            {
                // Cargamos la fecha 
                //DBAdapter.executeProcedure("CARGAR_FECHA_SISTEMA", CLC_SessionManager.getFecha() );
        


                var valido = repo.validarLogin(usuarioTextbox.Text, passwordTextbox.Text);
                if (valido == 1)
                {
                    this.Hide();
                    repo.iniciarSesion(usuarioTextbox.Text);
                    MessageBox.Show("Bienvenido " + CLC_SessionManager.currentUser.Nombre_Usuario, "Login exitoso");
                    new FunctionsMenu().ShowDialog();
                    this.Close();
                }
                else if (valido == -1)
                {
                    MessageBox.Show("Se dio de baja su usuario por exceder la cantidad de intentos de logueo");
                }
                else MessageBox.Show("Datos Incorrectos");
            }
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
        }

        private void passwordTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                button1.PerformClick();
        }
    }
}
