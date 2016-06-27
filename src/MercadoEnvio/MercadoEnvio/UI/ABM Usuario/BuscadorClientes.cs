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
            var retorno = new ClientesRepository().filtrarClientes(nombreTextBox.Text,apellidoTextBox.Text,Convert.ToInt32(dniTextBox.Text),mailTextBox.Text);
            var source = new BindingSource();
            source.DataSource = retorno;
            clientesGrid.DataSource = source;
        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var usuario = (DetallesClientes)clientesGrid.SelectedRows[0].DataBoundItem;
            new AltaCliente().ShowDialog(usuario);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var usuario = (DetallesClientes)clientesGrid.SelectedRows[0].DataBoundItem;
            new ClientesRepository().darDeBaja(usuario.Cod_Cliente);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BuscadorClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2016DataSet5.Detalles_Clientes' Puede moverla o quitarla según sea necesario.
            this.detalles_ClientesTableAdapter.Fill(this.gD1C2016DataSet5.Detalles_Clientes);

        }
    }
}
