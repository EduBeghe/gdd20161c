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
    public partial class ComprarOfertar : Form
    {
        public ComprarOfertar()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.FindForm().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2016DataSet2.Publicaciones' table. You can move, or remove it, as needed.
            this.publicacionesTableAdapter.Fill(this.gD1C2016DataSet2.Publicaciones);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (publicacionesGrid.SelectedRows.Count != 0)
            {
                new ComprarPublicacion().ShowDialog( (Publicaciones)publicacionesGrid.SelectedRows[0].DataBoundItem );
            }
            else MessageBox.Show("Debe seleccionar una publicacion para poder comprar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (publicacionesGrid.SelectedRows.Count != 0)
            {
                new OfertarPublicacion().ShowDialog((Publicaciones)publicacionesGrid.SelectedRows[0].DataBoundItem);
            }
            else MessageBox.Show("Debe seleccionar una publicacion para poder ofertar");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
