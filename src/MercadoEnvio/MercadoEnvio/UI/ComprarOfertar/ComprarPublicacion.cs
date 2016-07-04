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
        DataRow row;

        public ComprarPublicacion()
        {
            InitializeComponent();
        }

        internal void ShowDialog( DataRow dow )
        {
            this.row = dow;
            this.FindForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var codigoPublicacion = Convert.ToInt32(row["Cod_Publicacion"]);
            var retorno = new PublicacionRepository().comprarPublicacion(CLC_SessionManager.getDNI(), CLC_SessionManager.getCUIT(), codigoPublicacion, Convert.ToInt32(cantidadTextBox.Text), Convert.ToString(FormaDePagoComboBox.SelectedValue));
            if (retorno == 0)
            {
                MessageBox.Show("La compra ha sido realizada con exito.");
                this.Close();
            }
            else if (retorno == -1)
            {
                MessageBox.Show("Tiene que calificar las compras que no califico aun.");
                this.Close();
            }
            else if (retorno == -2)
            {
                MessageBox.Show("No hay suficiente stock.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Hubo un problema y no se pudo efectuar la compra.");
            }
        }

        private void ComprarPublicacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2016DataSet16.Formas_De_Pago' Puede moverla o quitarla según sea necesario.
            //this.formas_De_PagoTableAdapter.Fill(this.gD1C2016DataSet16.Formas_De_Pago);

        }

        private void cantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MercadoEnvio.Utils.Validacion.validateNumberTextBox(sender, e);
        }
    }
}
