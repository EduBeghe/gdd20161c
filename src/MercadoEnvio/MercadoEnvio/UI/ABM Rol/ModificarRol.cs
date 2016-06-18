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

namespace MercadoEnvio.UI.ABM_Rol
{
    public partial class ModificarRol : Form
    {
        Rol rol;

        public ModificarRol()
        {
            InitializeComponent();
        }

         internal void ShowDialog(Rol rol )
        {
            this.rol = Rol.Copy(rol);
            this.ShowDialog();
        }


        private void modificarButton_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text != "")
            {
                new RolesRepository().modificarNombre(rol, nombreTextBox.Text);
            }
            if (estadoCheckBox.Checked)
            {
                new RolesRepository().modificarEstado(rol, true);
            }
            else
            {
                new RolesRepository().modificarEstado(rol, false);
            }
            foreach (Object item in FuncionalidadesListBox.Items)
            {
                if (FuncionalidadesListBox.CheckedItems.Contains(item)
                    && !rol.funcionalidad.Exists(x => x.Descripcion_Funcionalidad == item.ToString())) { new RolesRepository().agregarRelacionRolFuncionabilidad(rol.Nombre, (Funcionalidades)item); }
                if (!FuncionalidadesListBox.CheckedItems.Contains(item) &&
                    rol.funcionalidad.Exists(x => x.Descripcion_Funcionalidad == item.ToString())) { new RolesRepository().quitarFuncionabilidad(rol.Cod_Rol, (Funcionalidades)item); }
            }
            MessageBox.Show("Rol modificado con exito");
            this.Close();
        }

        private void ModificarRol_Load(object sender, EventArgs e)
        {
            this.FuncionalidadesListBox.DataSource = new BindingSource(new BindingList<Funcionalidades>(new FuncionalidadRepository().getFuncionalidades()), null);

            for (int i = FuncionalidadesListBox.Items.Count - 1; i >= 0; i--)
            {
                if (rol.funcionalidad.Exists(x => x.Descripcion_Funcionalidad == FuncionalidadesListBox.Items[i].ToString()))
                {
                    FuncionalidadesListBox.SetItemCheckState(i, CheckState.Checked);
                }
            }
        }


    }
}
