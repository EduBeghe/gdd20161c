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
using MercadoEnvio.Utils;

namespace MercadoEnvio.UI.ABM_Visibilidad
{
    public partial class ListadoVisibilidad : Form
    {
        public ListadoVisibilidad()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.FindForm().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2016DataSet1.Visibilidades_Publicaciones' table. You can move, or remove it, as needed.
            this.visibilidades_PublicacionesTableAdapter.Fill(this.gD1C2016DataSet1.Visibilidades_Publicaciones);
            var usuario = CLC_SessionManager.currentUser;
            List<Funcionalidades> funcionalidades = new List<Funcionalidades>();
            foreach (Rol rol in usuario.roles)
            {
                funcionalidades.AddRange(rol.funcionalidad);
            }
            button2.Hide();
            button3.Hide();
            foreach (Funcionalidades funcionalidad in funcionalidades)
            {
                if (funcionalidad.Cod_Funcionalidad.Equals(11))
                {
                    button2.Show();
                }
                if (funcionalidad.Cod_Funcionalidad.Equals(12))
                {
                    button3.Show();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var count = visibilidadesGrid.SelectedRows.Count;
            if (count != 0)
            {
                var dataRowView = (DataRowView)visibilidadesGrid.SelectedRows[0].DataBoundItem;
                new VisibilidadRepository().bajaVisibilidad( new VisibilidadRepository().parse( dataRowView.Row ) );   
                MessageBox.Show("visibilidad eliminada con exito");
                this.Close();
            }
            else MessageBox.Show("Debe seleccionar una visibilidad para dar de baja");
        }

        private void visibilidadesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dataRowView = (DataRowView)visibilidadesGrid.SelectedRows[0].DataBoundItem;
            var visibilidad = new VisibilidadRepository().parse(dataRowView.Row);
            new AltaVisibilidad().ShowDialog(visibilidad.Cod_Visibilidad);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nobreTextBox.Text != "")
            {
                this.visibilidadesGrid.DataSource = new BindingSource(new BindingList<VisibilidadPublicaciones>(new VisibilidadRepository().filtrarVisibilidades(nobreTextBox.Text)), null);
            }
            else
            {
                this.visibilidadesGrid.DataSource = new BindingSource(new BindingList<VisibilidadPublicaciones>(new VisibilidadRepository().getVisibilidades()), null);
            }
        }
    }
}
