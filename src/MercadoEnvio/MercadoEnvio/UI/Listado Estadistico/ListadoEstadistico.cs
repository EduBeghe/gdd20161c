using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.Utils;
using MercadoEnvio.Domain;
using MercadoEnvio.Repositories;

namespace MercadoEnvio.UI.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }

        private DateTime parsearFechaInicial()
        {

            DateTime fecha = default(DateTime);
            switch (trimestreComboBox.SelectedIndex)
            {
                case 0:
                    fecha = Convert.ToDateTime("01/01/" + Convert.ToString(anioNumericUpDown.Value));
                    break;
                case 1:
                    fecha = Convert.ToDateTime("01/07/" + Convert.ToString(anioNumericUpDown.Value + 1));
                    break;
            }

            return fecha;

        }

        private DateTime parsearFechaFinal()
        {

            DateTime fecha = default(DateTime);
            switch (trimestreComboBox.SelectedIndex)
            {
                case 0:
                    fecha = Convert.ToDateTime("01/07/" + Convert.ToString(anioNumericUpDown.Value));
                    break;
                case 1:
                    fecha = Convert.ToDateTime("01/01/" + Convert.ToString(anioNumericUpDown.Value + 1));
                    break;
            }

            return fecha;

        }

        private void consultarButton_Click(object sender, EventArgs e)
        {
            if (!Validacion.estaVacio(trimestreComboBox, "Trimestre") && !Validacion.estaVacio(anioNumericUpDown, "año") )
            {

                DateTime fechaInicial = this.parsearFechaInicial();
                DateTime fechaFinal = this.parsearFechaFinal();

                switch (estadisticaComboBox.SelectedIndex)
                {
                    case 0:
                        {
                            this.estadisticaDataGridView.DataSource = DBAdapter.retrieveDataTable("Pasajes_Mas_Comprados", fechaInicial, fechaFinal);
                        }
                        break;

                    case 1:
                        {
                            this.estadisticaDataGridView.DataSource = DBAdapter.retrieveDataTable("Aeronaves_Mas_Vacias", fechaInicial, fechaFinal);
                        } break;

                    case 2:
                        {
                            this.estadisticaDataGridView.DataSource = DBAdapter.retrieveDataTable("Cliente_Mayoria_Puntos");
                        } break;

                    case 3:
                        {
                            this.estadisticaDataGridView.DataSource = DBAdapter.retrieveDataTable("Destinos_Mas_Cancelados", fechaInicial, fechaFinal);
                        } break;

                    case 4:
                        {
                            this.estadisticaDataGridView.DataSource = DBAdapter.retrieveDataTable("Aeronave_Mayoria_Fuera_Servicio", fechaInicial, fechaFinal);
                        } break;

                }

            }
        }
    }
}
