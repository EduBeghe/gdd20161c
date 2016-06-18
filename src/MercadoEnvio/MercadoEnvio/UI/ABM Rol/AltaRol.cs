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

namespace MercadoEnvio.ABM_Rol
{
    public partial class AltaRol : Form
    {
        public AltaRol()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }

        private void AltaButton_Click(object sender, EventArgs e)
        {
            if (Validacion.validarInputs(this.Controls))
            {
                var retorno = new RolesRepository().agregarRol(NombreRolTextBox.Text);
                foreach (Funcionalidades itemChecked in ListaRolesCheckedListBox.CheckedItems)
                {
                    new RolesRepository().relacionRolFuncionabilidad(NombreRolTextBox.Text, itemChecked );
                }
                if (retorno == 0)
                {
                    MessageBox.Show("Rol dato de alta exitosamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El rol que quiere dar de alta ya existe");
                }
            }
        }

        private void ListaRolesCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
