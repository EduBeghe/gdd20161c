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
            this.publicacionesGrid.DataSource = DBAdapter.retrieveDataTable("Filtrar_Publicaciones", rubroTextBox1.Text, rubroTextBox2.Text, rubroTextBox3.Text, descTextBox.Text, CLC_SessionManager.getDNI(), CLC_SessionManager.getCUIT());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (publicacionesGrid.SelectedRows.Count != 0)
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
            this.publicacionesGrid.DataSource = DBAdapter.retrieveDataTable("Filtrar_Publicaciones", rubroTextBox1.Text, rubroTextBox2.Text, rubroTextBox3.Text, descTextBox.Text, CLC_SessionManager.getDNI(), CLC_SessionManager.getCUIT());
        }

        private void publicacionesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    }
}
