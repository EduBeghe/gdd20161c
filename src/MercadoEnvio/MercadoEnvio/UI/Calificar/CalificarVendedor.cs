using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.Repositories;
using MercadoEnvio.Domain;
using MercadoEnvio.Utils;

namespace MercadoEnvio.Calificar
{
    public partial class CalificarVendedor : Form
    {

        public CalificarVendedor()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.FindForm().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comprasDataGridView.DataSource = DBAdapter.retrieveDataTable("Get_Compras_Por_Usuario", CLC_SessionManager.getDNI(), CLC_SessionManager.getCUIT() );
        }

        private void calificarButton_Click(object sender, EventArgs e)
        {
            var dataRowView = (DataRowView)comprasDataGridView.SelectedRows[0].DataBoundItem;
            var dataRow = (DataRow)dataRowView.Row;
            var codCompra = Convert.ToInt32(dataRow["Cod_Compra"]);
            
            foreach (Control control in panel1.Controls)
            {
                var radioButton = (RadioButton) control;
                if (radioButton.Checked )
                {
                    int retorno = new CalificarRepository().calificarCompra(
                        Convert.ToInt32( radioButton.Tag ),
                        codCompra,
                        descripcionTextBox.Text
                        );
                    if (retorno == -1)
                    {
                        MessageBox.Show("No puede calificar una compra ya calificada");
                    }
                    else if (retorno == -2)
                    {
                        MessageBox.Show("No puede calificar una subasta en proceso");
                    }
                    else
                    {
                        MessageBox.Show("Gracias por calificar");
                    }
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Debe seleccionar un calificacion para poder calificar");        
        }

    }
}
