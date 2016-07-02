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
            this.FindForm().ShowDialog();
        }

        private int parsearFechaInicial()
        {

            //DateTime fecha = default(DateTime);
            switch (trimestreComboBox.SelectedIndex)
            {
                case 0:
                    return 1;
                    //fecha = Convert.ToDateTime("01/01/" + Convert.ToString(anioNumericUpDown.Value));
                    //break;
                case 1:
                    return 3;
                    //fecha = Convert.ToDateTime("01/03/" + Convert.ToString(anioNumericUpDown.Value));
                    //break;
                case 2:
                    return 6;
                    //fecha = Convert.ToDateTime("01/06/" + Convert.ToString(anioNumericUpDown.Value));
                    //break;
                case 3:
                    return 9;
                    //fecha = Convert.ToDateTime("01/09/" + Convert.ToString(anioNumericUpDown.Value));
                    //break;
            }
            return 0;
            //return fecha;

        }

        private int parsearFechaFinal()
        {

            //DateTime fecha = default(DateTime);
            switch (trimestreComboBox.SelectedIndex)
            {
                case 0:
                    //fecha = Convert.ToDateTime("01/03/" + Convert.ToString(anioNumericUpDown.Value));
                    return 3;
                    //break;
                case 1:
                    //fecha = Convert.ToDateTime("01/06/" + Convert.ToString(anioNumericUpDown.Value));
                    //break;
                    return 6;
                case 2:
                    //fecha = Convert.ToDateTime("01/09/" + Convert.ToString(anioNumericUpDown.Value));
                    //break;
                    return 9;
                case 3:
                    //fecha = Convert.ToDateTime("01/12/" + Convert.ToString(anioNumericUpDown.Value));
                    //break;
                    return 12;
            }
            return 0;
            //return fecha;

        }

        private void consultarButton_Click(object sender, EventArgs e)
        {
            if (!Validacion.estaVacio(trimestreComboBox, "Trimestre") && !Validacion.estaVacio(anioNumericUpDown, "año") )
            {

                int fechaInicial = this.parsearFechaInicial();
                int fechaFinal = this.parsearFechaFinal();

                switch (estadisticaComboBox.SelectedIndex)
                {
                    case 0:
                        {
                            this.estadisticaDataGridView.DataSource = DBAdapter.retrieveDataTable("Vendedores_Mas_Perros", visibilidadComboBox.SelectedValue, fechaInicial, fechaFinal, anioNumericUpDown.Value);
                            break;
                        }
                    case 1:
                        {
                            this.estadisticaDataGridView.DataSource = DBAdapter.retrieveDataTable("Clientes_Con_Mayoria_De_Compras", fechaInicial, fechaFinal, rubroComboBox.SelectedValue, anioNumericUpDown.Value );
                            break;
                        } 
                    case 2:
                        {
                            this.estadisticaDataGridView.DataSource = DBAdapter.retrieveDataTable("Vendedores_Con_Mayoria_De_Facturas", fechaInicial, fechaFinal, anioNumericUpDown.Value);
                            break;
                        } 
                    case 3:
                        {
                            this.estadisticaDataGridView.DataSource = DBAdapter.retrieveDataTable("Vendedores_Con_Mayoria_De_Monto_Facturado", fechaInicial, fechaFinal, anioNumericUpDown.Value);
                            break;
                        } 
                }

            }
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2016DataSet8.Rubros' table. You can move, or remove it, as needed.
            this.rubrosTableAdapter.Fill(this.gD1C2016DataSet8.Rubros);
            // TODO: This line of code loads data into the 'gD1C2016DataSet7.Visibilidades_Publicaciones' table. You can move, or remove it, as needed.
            this.visibilidades_PublicacionesTableAdapter.Fill(this.gD1C2016DataSet7.Visibilidades_Publicaciones);

        }

        private void estadisticaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (estadisticaComboBox.SelectedIndex)
            {
                case 0:
                    {
                        rubroComboBox.Hide();
                        visibilidadComboBox.Show();
                        break;
                    }
                case 1:
                    {
                        rubroComboBox.Show();
                        visibilidadComboBox.Hide();
                        break;
                    }
                case 2:
                    {
                        rubroComboBox.Hide();
                        visibilidadComboBox.Hide();
                        break;
                    }
                case 3:
                    {
                        rubroComboBox.Hide();
                        visibilidadComboBox.Hide();
                        break;
                    }
            }
        }
    }
}
