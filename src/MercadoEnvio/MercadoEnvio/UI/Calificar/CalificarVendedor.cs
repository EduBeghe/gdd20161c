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

namespace MercadoEnvio.Calificar
{
    public partial class CalificarVendedor : Form
    {
        int codigoCompra;

        public CalificarVendedor()
        {
            InitializeComponent();
        }

        internal void ShowDialog( int codigoCompra )
        {
            this.codigoCompra = codigoCompra;
            this.FindForm().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2016DataSet6.Compras' table. You can move, or remove it, as needed.
            this.comprasTableAdapter.Fill(this.gD1C2016DataSet6.Compras);
        }

        private void calificarButton_Click(object sender, EventArgs e)
        {
            var dataRowView = (DataRowView)comprasDataGridView.SelectedRows[0].DataBoundItem;
            var compra = new ComprasRepository().
            new AltaVisibilidad().ShowDialog(visibilidad.Cod_Visibilidad);
            foreach (Control control in panel1.Controls)
            {
                var radioButton = (RadioButton) control;
                if (radioButton.Checked )
                {
                    new CalificarRepository().calificarCompra(
                        Convert.ToInt32( radioButton.Tag ),
                        codigoCompra,
                        descripcionTextBox.Text
                        );
                    MessageBox.Show("Gracias por calificar");        
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Debe seleccionar un calificacion para poder calificar");        
        }

    }
}
