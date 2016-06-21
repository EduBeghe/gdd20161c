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
using MercadoEnvio.UI.ABM_Visibilidad;

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
            var count = visibilidadesGrid.SelectedRows.Count;
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    var visibilidad = (VisibilidadPublicaciones)visibilidadesGrid.SelectedRows[i].DataBoundItem;
                    new VisibilidadRepository().bajaVisibilidad(visibilidad);   
                }
                MessageBox.Show("Visibilidades eliminadas con exito");
                this.Close();
            }
            else MessageBox.Show("Debe seleccionar una visibilidad para dar de baja");
        }

        private void visibilidadesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cells = visibilidadesGrid.SelectedRows[0].DataBoundItem;
            new AltaVisibilidad().ShowDialog();
        }
    }
}
