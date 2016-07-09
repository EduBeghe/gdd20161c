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
            var retorno = new ClientesRepository().getClientes();
            if (   !( nombreTextBox.Text == "" &&
                    apellidoTextBox.Text == "" &&
                    dniTextBox.Text == "" &&
                    mailTextBox.Text == "" ) )
            {
               retorno = new ClientesRepository().filtrarClientes(
                    nombreTextBox.Text != "" ? nombreTextBox.Text : "",
                    apellidoTextBox.Text != "" ? apellidoTextBox.Text : "",
                    dniTextBox.Text != "" ? Convert.ToInt32(dniTextBox.Text) : 0,
                    mailTextBox.Text != "" ? mailTextBox.Text : ""
                    );
            }
            this.clientesGrid.DataSource = new BindingSource(new BindingList<DetallesClientes>(retorno), null);
        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dataRowView = (DataRowView)clientesGrid.SelectedRows[0].DataBoundItem;
            var clienteRepo = new AltaCliente();
            clienteRepo.ShowDialog(new ClientesRepository().parse(dataRowView.Row));
            this.detalles_ClientesTableAdapter.Fill(this.gD1C2016DataSet4.Detalles_Clientes);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dataRowView = (DataRowView)clientesGrid.SelectedRows[0].DataBoundItem;
            var usuario = new ClientesRepository().parse(dataRowView.Row);
            new ClientesRepository().darDeBaja(usuario.Cod_Cliente);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BuscadorClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2016DataSet4.Detalles_Clientes' table. You can move, or remove it, as needed.
            this.detalles_ClientesTableAdapter.Fill(this.gD1C2016DataSet4.Detalles_Clientes);
            var usuario = CLC_SessionManager.currentUser;
            List<Funcionalidades> funcionalidades = new List<Funcionalidades>();
            foreach (Rol rol in usuario.roles)
            {
                funcionalidades.AddRange(rol.funcionalidad);
            }
            button2.Hide();
            button3.Hide();
            foreach (Funcionalidades funcionalidad in funcionalidades)
            {
                if (funcionalidad.Cod_Funcionalidad.Equals(5))
                {
                    button2.Show();
                }
                if (funcionalidad.Cod_Funcionalidad.Equals(6))
                {
                    button3.Show();
                }
            }
        }
    }
}
