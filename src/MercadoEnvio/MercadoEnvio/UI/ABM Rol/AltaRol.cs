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
            this.FindForm().ShowDialog();
        }
        
        private void AltaButton_Click(object sender, EventArgs e)
        {
            if (Validacion.validarInputs(this.Controls))
            {
                var retornoAlta = new RolesRepository().agregarRol(NombreRolTextBox.Text);
                if (retornoAlta == 0)
                {
                    MessageBox.Show("Rol dato de alta exitosamente");
                    var success = true;
                    foreach (Funcionalidades itemChecked in ListaFuncionalidadesCheckedListBox.CheckedItems)
                    {
                        var retornoAgregarFuncionabilidad = new RolesRepository().agregarRelacionRolFuncionabilidad(NombreRolTextBox.Text, itemChecked);
                        if (retornoAgregarFuncionabilidad != 0)
                        {
                            success = false;
                        }
                    }
                    if (!success)
                    {
                        MessageBox.Show("Una o mas funcionalidades no pudieron ser agregadas.");
                    }
                    else
                    {
                        MessageBox.Show("Las funcionalidades fueron agregadas al rol exitosamente.");
                    }
                    this.Close();
                }
                else {
                    MessageBox.Show("El rol que quiere dar de alta ya existe");
                }
            }
        }

        private void ListaRolesCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AltaRol_Load(object sender, EventArgs e)
        {
            ( (ListBox) this.ListaFuncionalidadesCheckedListBox ).DataSource = new BindingSource(new BindingList<Funcionalidades>(new FuncionalidadRepository().getFuncionalidades()), null);
            ( (ListBox)this.ListaFuncionalidadesCheckedListBox).DisplayMember = "Descripcion_Funcionalidad";
        }
    }
}
