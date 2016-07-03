using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.UI.ABM_Rol;
using MercadoEnvio.ABM_Rol;
using MercadoEnvio.ABM_Usuario;
using MercadoEnvio.Calificar;
using MercadoEnvio.ComprarOfertar;
using MercadoEnvio.UI;

namespace MercadoEnvio.UI.Menu
{
    public partial class FunctionsMenu : Form
    {
        public FunctionsMenu()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.FindForm().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Listado().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AltaRol().ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //new AltaUsuario().ShowDialog();
            new UI.ABM_Usuario.AltaCliente().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //new UI.ABM_Usuario.BuscadorClientes().ShowDialog();
        }

        private void FunctionsMenu_Load(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new UI.ABM_Usuario.BuscadorClientes().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new UI.ABM_Usuario.AltaEmpresa().ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new UI.ABM_Visibilidad.AltaVisibilidad().ShowDialog(true);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new UI.ABM_Visibilidad.ListadoVisibilidad().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new UI.ABM_Usuario.BuscadorEmpresas().ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new Calificar.CalificarVendedor().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new UI.Listado_Estadistico.ListadoEstadistico().ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            new Historial_Cliente.Form1().ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            new Generar_Publicación.GenerarPublicaciones().ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new ListadoComprarOfertar().ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new AltaUsuario().ShowDialog();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            new Facturas.ConsultaFacturas().ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new Generar_Publicación.ListadoPublicaciones().ShowDialog();
        }
    }
}
 