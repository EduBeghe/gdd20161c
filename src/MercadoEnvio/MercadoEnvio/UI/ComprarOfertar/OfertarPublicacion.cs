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
using MercadoEnvio.Utils;
using MercadoEnvio.Repositories;

namespace MercadoEnvio.UI.ComprarOfertar
{
    public partial class OfertarPublicacion : Form
    {
        Publicaciones publicacion;

        public OfertarPublicacion()
        {
            InitializeComponent();
        }

        internal void ShowDialog(Publicaciones publicacion)
        {
            this.publicacion = publicacion;
            this.FindForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PublicacionRepository().ofertarPublicacion(
               this.publicacion,
               Convert.ToInt32(this.ofertarTextBox.Text)
           );
        }
    }
}
