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
            // TODO: esta línea de código carga datos en la tabla 'gD1C2016DataSet13.Detalles_Empresas' Puede moverla o quitarla según sea necesario.
            this.detalles_EmpresasTableAdapter.Fill(this.gD1C2016DataSet13.Detalles_Empresas);
            // TODO: esta línea de código carga datos en la tabla 'gD1C2016DataSet12.Detalles_Empresas' Puede moverla o quitarla según sea necesario.
            razonSocialTextBox.Text = "";
            cuitTextBox.Text = "";
            emailTextBox.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var retorno = new EmpresaRepository().filtrarEmpresas(
                razonSocialTextBox.Text,
                cuitTextBox.Text,
                emailTextBox.Text
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
            var repoEmpresa = new AltaEmpresa();
            repoEmpresa.ShowDialog(new EmpresaRepository().parse(dataRowView.Row));
            this.detalles_EmpresasTableAdapter.Fill(this.gD1C2016DataSet13.Detalles_Empresas);
        }
    }
}
