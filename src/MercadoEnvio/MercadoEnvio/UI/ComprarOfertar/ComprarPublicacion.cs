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

namespace MercadoEnvio.UI.ComprarOfertar
{
    public partial class ComprarPublicacion : Form
    {
        Publicaciones publicacion;

        public ComprarPublicacion()
        {
            InitializeComponent();
        }

        internal void ShowDialog( Publicaciones publicacion )
        {
            this.publicacion = publicacion;
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PublicacionRepository().comprarPublicacion( 
                this.publicacion,
                Convert.ToInt32( this.cantidadTextBox.Text ),
                FormaDePagoComboBox.SelectedItem as String
            );
        }
    }
}
