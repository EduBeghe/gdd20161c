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
using MercadoEnvio.UI;
using MercadoEnvio.UI.ComprarOfertar;

namespace MercadoEnvio.ComprarOfertar
{
    public partial class ListadoComprarOfertar : Form
    {

        int pagesCounter;
        int pagesMax;

        public ListadoComprarOfertar()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.FindForm().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.publicacionesGrid.DataSource = new PublicacionRepository().filtrarPublicacionesPaginado(rubroTextBox1.Text, descTextBox.Text, 1, CLC_SessionManager.getDNI(), CLC_SessionManager.getCUIT());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (publicacionesGrid.SelectedRows != null && publicacionesGrid.SelectedRows.Count != 0)
            {
                var dataRowView = (DataRowView)publicacionesGrid.SelectedRows[0].DataBoundItem;
                new ComprarPublicacion().ShowDialog(dataRowView.Row);
            }
            else MessageBox.Show("Debe seleccionar una publicacion para poder comprar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (publicacionesGrid.SelectedRows.Count != 0)
            {
                var dataRowView = (DataRowView)publicacionesGrid.SelectedRows[0].DataBoundItem;
                new OfertarPublicacion().ShowDialog( dataRowView.Row );
            }
            else MessageBox.Show("Debe seleccionar una publicacion para poder ofertar");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.publicacionesGrid.DataSource = new PublicacionRepository().filtrarPublicacionesPaginado(rubroTextBox1.Text, descTextBox.Text, 1, CLC_SessionManager.getDNI(), CLC_SessionManager.getCUIT());
        }

        private void publicacionesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.pagesCounter = 1;
            this.publicacionesGrid.DataSource = new PublicacionRepository().filtrarPublicacionesPaginado(rubroTextBox1.Text, descTextBox.Text, 1, CLC_SessionManager.getDNI(), CLC_SessionManager.getCUIT());
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.pagesCounter = this.pagesMax;
            this.publicacionesGrid.DataSource = new PublicacionRepository().filtrarPublicacionesPaginado(rubroTextBox1.Text, descTextBox.Text, this.pagesMax, CLC_SessionManager.getDNI(), CLC_SessionManager.getCUIT());
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pagesCounter < this.pagesMax)
            {
                pagesCounter++;
                this.publicacionesGrid.DataSource = new PublicacionRepository().filtrarPublicacionesPaginado(rubroTextBox1.Text, descTextBox.Text, pagesCounter, CLC_SessionManager.getDNI(), CLC_SessionManager.getCUIT());
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
                this.publicacionesGrid.DataSource = new PublicacionRepository().filtrarPublicacionesPaginado(rubroTextBox1.Text, descTextBox.Text, pagesCounter, CLC_SessionManager.getDNI(), CLC_SessionManager.getCUIT());
            }
            else
            {
                MessageBox.Show("Esta en la primera pagina, no hay pagina anterior.");
            }
        }

    }
}
