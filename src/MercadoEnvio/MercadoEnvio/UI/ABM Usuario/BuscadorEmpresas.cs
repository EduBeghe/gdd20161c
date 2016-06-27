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
    public partial class BuscadorEmpresas : Form
    {
        public BuscadorEmpresas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BuscadorEmpresas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2016DataSet4.Detalles_Empresas' Puede moverla o quitarla según sea necesario.
            this.detalles_EmpresasTableAdapter.Fill(this.gD1C2016DataSet4.Detalles_Empresas);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var retorno = new EmpresaRepository().filtrarEmpresas(razonSocialTextBox.Text, cuitTextBox.Text, emailTextBox.Text);
            var source = new BindingSource();
            source.DataSource = retorno;
            empresasGrid.DataSource = source;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var empresa = (DetalleEmpresa)empresasGrid.SelectedRows[0].DataBoundItem;
            new AltaEmpresa().ShowDialog(empresa);
        }
    }
}
