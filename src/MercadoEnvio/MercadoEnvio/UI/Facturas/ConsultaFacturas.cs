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

namespace MercadoEnvio.Facturas
{
    public partial class ConsultaFacturas : Form
    {
        int pagesCounter;
        int pagesMax;

        public ConsultaFacturas()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.FindForm().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pagesCounter = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.importeInicialTextBox.Text != null && this.importeFinalTextBox.Text!=null)
            {
                this.facturasDataGrid.DataSource = new FacturasRepository().filtrarConsultasPaginado(CLC_SessionManager.getDNI(),
                CLC_SessionManager.getCUIT(),
                Convert.ToDateTime(this.DesdeDateTimePicker.Value),
                Convert.ToDateTime(this.hastaDateTimePicker.Value),
                Convert.ToInt32(this.importeInicialTextBox.Text),
                Convert.ToInt32(this.importeFinalTextBox.Text),
                1);
                var resultCount = new FacturasRepository().getCantidadResultados(CLC_SessionManager.getDNI(),
                    CLC_SessionManager.getCUIT(),
                    Convert.ToDateTime(this.DesdeDateTimePicker.Value),
                    Convert.ToDateTime(this.hastaDateTimePicker.Value),
                    Convert.ToInt32(this.importeInicialTextBox.Text),
                    Convert.ToInt32(this.importeFinalTextBox.Text));
                if (resultCount % 10 > 0)
                {
                    this.pagesMax = (resultCount / 10) + 1;
                }
                else
                {
                    this.pagesMax = (resultCount / 10);
                }
                this.pagesCounter = 1;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void desde(object sender, KeyPressEventArgs e)
        {
            MercadoEnvio.Utils.Validacion.validateNumberTextBox(sender, e);
        }

        private void hasta(object sender, KeyPressEventArgs e)
        {
            MercadoEnvio.Utils.Validacion.validateNumberTextBox(sender, e);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.pagesCounter = 1;
            this.facturasDataGrid.DataSource = new FacturasRepository().filtrarConsultasPaginado(CLC_SessionManager.getDNI(),
                CLC_SessionManager.getCUIT(),
                Convert.ToDateTime(this.DesdeDateTimePicker.Value),
                Convert.ToDateTime(this.hastaDateTimePicker.Value),
                Convert.ToInt32(this.importeInicialTextBox.Text),
                Convert.ToInt32(this.importeFinalTextBox.Text),
                1);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.pagesCounter = this.pagesMax;
            this.facturasDataGrid.DataSource = new FacturasRepository().filtrarConsultasPaginado(CLC_SessionManager.getDNI(),
                CLC_SessionManager.getCUIT(),
                Convert.ToDateTime(this.DesdeDateTimePicker.Value),
                Convert.ToDateTime(this.hastaDateTimePicker.Value),
                Convert.ToInt32(this.importeInicialTextBox.Text),
                Convert.ToInt32(this.importeFinalTextBox.Text),
                this.pagesMax);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pagesCounter < this.pagesMax)
            {
                pagesCounter++;
                this.facturasDataGrid.DataSource = new FacturasRepository().filtrarConsultasPaginado(CLC_SessionManager.getDNI(),
                CLC_SessionManager.getCUIT(),
                Convert.ToDateTime(this.DesdeDateTimePicker.Value),
                Convert.ToDateTime(this.hastaDateTimePicker.Value),
                Convert.ToInt32(this.importeInicialTextBox.Text),
                Convert.ToInt32(this.importeFinalTextBox.Text),
                this.pagesCounter);
            }
            else
            {
                MessageBox.Show("Esta en la ultima pagina, no hay mas paginas.");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pagesCounter > 1)
            {
                pagesCounter--;
                this.facturasDataGrid.DataSource = new FacturasRepository().filtrarConsultasPaginado(CLC_SessionManager.getDNI(),
                CLC_SessionManager.getCUIT(),
                Convert.ToDateTime(this.DesdeDateTimePicker.Value),
                Convert.ToDateTime(this.hastaDateTimePicker.Value),
                Convert.ToInt32(this.importeInicialTextBox.Text),
                Convert.ToInt32(this.importeFinalTextBox.Text),
                this.pagesCounter);
            }
            else
            {
                MessageBox.Show("Esta en la primera pagina, no hay pagina anterior.");
            }
        }

    }
}
