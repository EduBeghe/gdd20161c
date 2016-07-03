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
            // TODO: esta línea de código carga datos en la tabla 'gD1C2016DataSet15.Publicaciones' Puede moverla o quitarla según sea necesario.
            // TODO: This line of code loads data into the 'gD1C2016DataSet2.Publicaciones' table. You can move, or remove it, as needed.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (publicacionesGrid.SelectedRows.Count != 0)
            {
                var dataRowView = (DataRowView)publicacionesGrid.SelectedRows[0].DataBoundItem;
                //var publicacion = new PublicacionRepository().parse(dataRowView.Row);
                new ComprarPublicacion().ShowDialog(dataRowView.Row);
            }
            else MessageBox.Show("Debe seleccionar una publicacion para poder comprar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (publicacionesGrid.SelectedRows.Count != 0)
            {
                var dataRowView = (DataRowView)publicacionesGrid.SelectedRows[0].DataBoundItem;
                var publicacion = new PublicacionRepository().parse(dataRowView.Row);
                new OfertarPublicacion().ShowDialog( dataRowView.Row );
            }
            else MessageBox.Show("Debe seleccionar una publicacion para poder ofertar");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
