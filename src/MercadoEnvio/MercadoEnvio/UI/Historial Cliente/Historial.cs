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
using MercadoEnvio.Repositories;

namespace MercadoEnvio.Historial_Cliente
{
    public partial class Form1 : Form
    {
        int pagesCounter;
        int pagesMax;

        public Form1()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.FindForm().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validacion.estaVacio(filtroComboBox, "Filtro"))
            {
                switch (filtroComboBox.SelectedIndex)
                {
                    case 0:
                        {
                            this.pagesCounter = 1;
                            var resultCount = new ClientesRepository().getCantidadResultados(CLC_SessionManager.getDNI());
                            if (resultCount % 10 > 0)
                            {
                                this.pagesMax = (resultCount / 10) + 1;
                            }
                            else
                            {
                                this.pagesMax = (resultCount / 10);
                            }
                            this.historialDataGridView.DataSource = new ClientesRepository().filtrarClientesPaginado(CLC_SessionManager.getDNI(),1);
                            break;
                        }
                    case 1:
                        {
                            this.historialDataGridView.DataSource = DBAdapter.retrieveDataTable("Historial_Cliente_Calficaciones", CLC_SessionManager.getDNI());
                            break;
                        }
                }
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.pagesCounter = this.pagesMax;
            this.historialDataGridView.DataSource = new ClientesRepository().filtrarClientesPaginado(CLC_SessionManager.getDNI(), this.pagesMax);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.pagesCounter = 1;
            this.historialDataGridView.DataSource = new ClientesRepository().filtrarClientesPaginado(CLC_SessionManager.getDNI(), 1);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pagesCounter > 1)
            {
                pagesCounter--;
                this.historialDataGridView.DataSource = new ClientesRepository().filtrarClientesPaginado(CLC_SessionManager.getDNI(), this.pagesCounter);
            }
            else
            {
                MessageBox.Show("Esta en la primera pagina, no hay pagina anterior.");
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pagesCounter < this.pagesMax)
            {
                pagesCounter++;
                this.historialDataGridView.DataSource = new ClientesRepository().filtrarClientesPaginado(CLC_SessionManager.getDNI(), this.pagesCounter);
            }
            else
            {
                MessageBox.Show("Esta en la ultima pagina, no hay mas paginas.");
            }
        }
    }
}