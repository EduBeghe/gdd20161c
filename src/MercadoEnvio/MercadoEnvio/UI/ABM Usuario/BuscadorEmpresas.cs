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
            // TODO: This line of code loads data into the 'gD1C2016DataSet14.Detalles_Empresas' table. You can move, or remove it, as needed.
            this.detalles_EmpresasTableAdapter.Fill(this.gD1C2016DataSet14.Detalles_Empresas);
            
            razonSocialTextBox.Text = "";
            cuitTextBox.Text = "";
            emailTextBox.Text = "";

            var usuario = CLC_SessionManager.currentUser;
            var funcionalidades = usuario.rol.funcionalidad;
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
        }
    }
}
