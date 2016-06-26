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
    public partial class Form1 : Form
    {
        int codigoCompra;

        public Form1()
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

        }

        private void calificarButton_Click(object sender, EventArgs e)
        {
            
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
