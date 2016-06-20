using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.Domain;
using MercadoEnvio.Repositories;
using MercadoEnvio.Utils;

namespace MercadoEnvio.UI.ABM_Visibilidad
{
    public partial class AltaVisibilidad : Form
    {
        public AltaVisibilidad()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }

        private void AltaVisibilidad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( Validacion.validarInputs( this.Controls ) ) 
            {

                var retorno = new VisibilidadRepository().altaVisibilidad(
                    this.descripcionTextBox.Text,
                    Convert.ToInt32(this.precioTextBox), 
                    Convert.ToInt32(this.PorcentajeTextBox),
                    Convert.ToInt32(this.comisionTextBox)
                    );
            }
        }
    }
}
