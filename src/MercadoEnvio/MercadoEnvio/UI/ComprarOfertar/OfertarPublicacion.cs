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
        DataRow row;

        public OfertarPublicacion()
        {
            InitializeComponent();
        }

        internal void ShowDialog(DataRow row)
        {
            this.row = row;
            this.FindForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var codigoPublicacion = Convert.ToInt32(row["Cod_Publicacion"]);
            var retorno = new PublicacionRepository().ofertarPublicacion(CLC_SessionManager.getDNI(), CLC_SessionManager.getCUIT(), codigoPublicacion, Convert.ToInt32(ofertarTextBox.Text));
            if (retorno == 0)
            {
                MessageBox.Show("La oferta ha sido realizada con exito.");
                this.Close();
            }
            else if (retorno == -1)
            {
                MessageBox.Show("La oferta es menor al precio inicial de la subasta.");
            }
            else if (retorno == -2)
            {
                MessageBox.Show("Tiene que calificar las compras que no califico aun.");
            }
            else
            {
                MessageBox.Show("Hubo un problema y no se pudo efectuar la oferta.");
            }
        }

        private void OfertarPublicacion_Load(object sender, EventArgs e)
        {

        }
    }
}
