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
using MercadoEnvio.Domain;
using MercadoEnvio.Repositories;
using MercadoEnvio.Utils;

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
            var usuario = CLC_SessionManager.currentUser;
            List<Funcionalidades> funcionalidades = new List<Funcionalidades>();
            foreach( Rol rol in usuario.roles )
            {
                funcionalidades.AddRange( rol.funcionalidad );
            }
            button1.Hide();
            button9.Hide();
            button2.Hide();
            button14.Hide();
            button12.Hide();
            button15.Hide();
            button11.Hide();
            button13.Hide();
            button5.Hide();
            foreach(Funcionalidades funcionalidad in funcionalidades)
            {
                if(funcionalidad.Cod_Funcionalidad.Equals(1))
                {
                    button1.Show();
                }
                if(funcionalidad.Cod_Funcionalidad.Equals(10))
                {
                    button9.Show();
                }
                if(funcionalidad.Cod_Funcionalidad.Equals(4))
                {
                    button2.Show();
                }
                if (funcionalidad.Cod_Funcionalidad.Equals(13))
                {
                    button14.Show();
                } 
                if(funcionalidad.Cod_Funcionalidad.Equals(14))
                {
                    button12.Show();
                }
                if (funcionalidad.Cod_Funcionalidad.Equals(15))
                {
                    button15.Show();
                }
                if(funcionalidad.Cod_Funcionalidad.Equals(16))
                {
                    button11.Show();
                }
                if(funcionalidad.Cod_Funcionalidad.Equals(17))
                {
                    button13.Show();
                }
                if(funcionalidad.Cod_Funcionalidad.Equals(18))
                {
                    button5.Show();
                }
                if (CLC_SessionManager.esEmpresa())
                {
                    button12.Hide();
                    button8.Hide();
                    button4.Hide();
                    button2.Hide();
                }
                if (CLC_SessionManager.esCliente())
                {
                    button8.Hide();
                    button4.Hide();
                    button2.Hide();
                }
                if (CLC_SessionManager.esAdministrador())
                {
                    button11.Hide();
                    button12.Hide();
                    button14.Hide();
                }
            }
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

        private void button16_Click(object sender, EventArgs e)
        {
            new CambiarPassword().ShowDialog();
        }
    }
}
 