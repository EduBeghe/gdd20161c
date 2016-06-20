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

namespace MercadoEnvio.ABM_Visibilidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2016DataSet1.Visibilidades_Publicaciones' table. You can move, or remove it, as needed.
            this.visibilidades_PublicacionesTableAdapter.Fill(this.gD1C2016DataSet1.Visibilidades_Publicaciones);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (visibilidadesGrid.SelectedRows.Count != 0)
            {
                var visibilidad = (VisibilidadPublicaciones)visibilidadesGrid.SelectedRows[0].DataBoundItem;
                new VisibilidadRepository().bajaVisibilidad(visibilidad);
                MessageBox.Show("Visibilidad eliminada con exito");
                this.Close();
            }
            else MessageBox.Show("Debe seleccionar una visibilidad para dar de baja");
        }
    }
}
