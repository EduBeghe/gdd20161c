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
    public partial class BuscadorClientes : Form
    {
        public BuscadorClientes()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.FindForm().ShowDialog();
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
            var usuario = (DetallesClientes)usuariosGrid.SelectedRows[0].DataBoundItem;
            new AltaCliente().ShowDialog(usuario);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var usuario = (DetallesClientes)usuariosGrid.SelectedRows[0].DataBoundItem;
            new ClientesRepository().darDeBaja(usuario.Cod_Cliente);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
