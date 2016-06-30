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

        private void BuscadorEmpresas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2016DataSet5.Detalles_Empresas' table. You can move, or remove it, as needed.
            this.detalles_EmpresasTableAdapter.Fill(this.gD1C2016DataSet5.Detalles_Empresas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var retorno = new EmpresaRepository().filtrarEmpresas(
                razonSocialTextBox.Text != "" ? razonSocialTextBox.Text : "",
                cuitTextBox.Text != "" ? cuitTextBox.Text : "",
                emailTextBox.Text != "" ? emailTextBox.Text : ""
                );
            this.empresasGrid.DataSource = new BindingSource(new BindingList<DetalleEmpresa>(retorno), null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dataRowView = (DataRowView)empresasGrid.SelectedRows[0].DataBoundItem;
            var empresa = new EmpresaRepository().parse(dataRowView.Row);
            new EmpresaRepository().darDeBaja(empresa.Cod_Empresa);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dataRowView = (DataRowView)empresasGrid.SelectedRows[0].DataBoundItem;
            new AltaEmpresa().ShowDialog( new EmpresaRepository().parse( dataRowView.Row ));
        }
    }
}
