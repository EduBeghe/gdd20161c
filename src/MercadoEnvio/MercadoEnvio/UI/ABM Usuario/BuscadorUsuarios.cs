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
using MercadoEnvio.Domain;
using MercadoEnvio.Repositories;

namespace MercadoEnvio.UI.ABM_Usuario
{
    public partial class BuscadorUsuarios : Form
    {
        public BuscadorUsuarios()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var usuario = (Usuario)usuariosGrid.SelectedRows[0].DataBoundItem;
            if (usuario.rol.Cod_Rol.Equals(1))
            {
                new AltaCliente().ShowDialog(usuario.Nombre_Usuario);
            }
            else if (usuario.rol.Cod_Rol.Equals(2))
            {
                new AltaEmpresa().ShowDialog(usuario.Nombre_Usuario);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var usuario = (Usuario)usuariosGrid.SelectedRows[0].DataBoundItem;
            new UsuariosRepository().bajaUsuario(usuario.Nombre_Usuario);
        }
    }
}
