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
        public Form1()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
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
                    var retorno = new Cal
                    return;
                }
            }
            MessageBox.Show("Debe seleccionar un calificacion para poder calificar");        
        }

    }
}
