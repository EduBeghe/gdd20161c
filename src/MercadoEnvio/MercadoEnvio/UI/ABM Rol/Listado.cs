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
    public partial class Listado : Form
    {
        public Listado()
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

        private void Listado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2016DataSet.Roles' Puede moverla o quitarla según sea necesario.
            this.rolesTableAdapter.Fill(this.gD1C2016DataSet.Roles);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text != "") this.rolesList.DataSource = new BindingSource(new BindingList<Rol>(new RolesRepository().findRol(nombreTextBox.Text)), null);
            else this.rolesList.DataSource = new BindingSource(new BindingList<Rol>(new RolesRepository().getRoles()), null); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rolesList.SelectedRows.Count != 0)
            {
                var dataViewRow = (DataRowView)rolesList.SelectedRows[0].DataBoundItem;
                new RolesRepository().darDeBaja( new RolesRepository().parse( dataViewRow.Row) );
                MessageBox.Show("Rol eliminado con exito");
                this.Close();
            }
            else MessageBox.Show("Debe seleccionar un rol para dar de baja");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rolesList.SelectedRows.Count != 0)
            {
                var dataRowView = (DataRowView)rolesList.SelectedRows[0].DataBoundItem;
                new UI.ABM_Rol.ModificarRol().ShowDialog( new RolesRepository().parse( dataRowView.Row ) ); 
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rol para modificar");
            }
        }
    }
}
