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
            if (!rol.Nombre.Equals(nombreTextBox.Text))
            {
                new RolesRepository().modificarNombre(rol, nombreTextBox.Text);
            }
            if (!rol.Estado_Rol.Equals(estadoCheckBox.Checked))
            {
                new RolesRepository().modificarEstado(rol, estadoCheckBox.Checked);
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
            nombreTextBox.Text = rol.Nombre;
            this.FuncionalidadesListBox.DataSource = new BindingSource(new BindingList<Funcionalidades>(new FuncionalidadRepository().getFuncionalidades()), null);
            ((ListBox)this.FuncionalidadesListBox).DisplayMember = "Descripcion_Funcionalidad";
            estadoCheckBox.Checked = rol.Estado_Rol;
            for (int i = FuncionalidadesListBox.Items.Count - 1; i >= 0; i--)
            {
                if (rol.funcionalidad.Exists(x => x.Descripcion_Funcionalidad == ( (Funcionalidades) FuncionalidadesListBox.Items[i] ).Descripcion_Funcionalidad  ))
                {
                    FuncionalidadesListBox.SetItemCheckState(i, CheckState.Checked);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
