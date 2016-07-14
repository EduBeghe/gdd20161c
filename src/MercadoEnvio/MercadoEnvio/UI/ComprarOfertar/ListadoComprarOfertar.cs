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
            // TODO: esta línea de código carga datos en la tabla 'gD1C2016DataSet18.Estados_Publicaciones' Puede moverla o quitarla según sea necesario.
            this.pagesCounter = 1;
            this.estados_PublicacionesTableAdapter.Fill(this.gD1C2016DataSet18.Estados_Publicaciones);
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
            var estado = (string)estadoComboBox.SelectedValue;
            var resultsAmount = new PublicacionRepository().getCantidadResultados(rubroTextBox1.Text, descTextBox.Text, CLC_SessionManager.getDNI(), CLC_SessionManager.getCUIT(), estado);
            if (resultsAmount % 10 > 0)
            {
                this.pagesMax = (resultsAmount / 10) + 1;
            }
            else
            {
                this.pagesMax = (resultsAmount / 10);
            }
            this.publicacionesGrid.DataSource = new PublicacionRepository().filtrarPublicacionesPaginado(rubroTextBox1.Text, descTextBox.Text, 1, CLC_SessionManager.getDNI(), CLC_SessionManager.getCUIT(), estado);
        }

        private void publicacionesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.pagesCounter = 1;
            var estado = (string)estadoComboBox.SelectedValue;
            this.publicacionesGrid.DataSource = new PublicacionRepository().filtrarPublicacionesPaginado(rubroTextBox1.Text, descTextBox.Text, 1, CLC_SessionManager.getDNI(), CLC_SessionManager.getCUIT(), estado);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.pagesCounter = this.pagesMax;
            var estado = (string)estadoComboBox.SelectedValue;
            this.publicacionesGrid.DataSource = new PublicacionRepository().filtrarPublicacionesPaginado(rubroTextBox1.Text, descTextBox.Text, this.pagesMax, CLC_SessionManager.getDNI(), CLC_SessionManager.getCUIT(), estado);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pagesCounter < this.pagesMax)
            {
                pagesCounter++;
                var estado = (string)estadoComboBox.SelectedValue;
                this.publicacionesGrid.DataSource = new PublicacionRepository().filtrarPublicacionesPaginado(rubroTextBox1.Text, descTextBox.Text, pagesCounter, CLC_SessionManager.getDNI(), CLC_SessionManager.getCUIT(), estado);
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
                var estado = (string)estadoComboBox.SelectedValue;
                this.publicacionesGrid.DataSource = new PublicacionRepository().filtrarPublicacionesPaginado(rubroTextBox1.Text, descTextBox.Text, pagesCounter, CLC_SessionManager.getDNI(), CLC_SessionManager.getCUIT(), estado);
            }
            else
            {
                MessageBox.Show("Esta en la primera pagina, no hay pagina anterior.");
            }
        }

    }
}
