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
using MercadoEnvio.Domain;


namespace MercadoEnvio.UI.Generar_Publicación
{
    public partial class ListadoPublicaciones : Form
    {
        public ListadoPublicaciones()
        {
            InitializeComponent();
        }

        private void ListadoPublicaciones_Load(object sender, EventArgs e)
        {
            this.publicacionesDataGridView.DataSource = DBAdapter.retrieveDataTable("Publicaciones_Modificables", CLC_SessionManager.getDNI(), CLC_SessionManager.getCUIT());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (publicacionesDataGridView.SelectedRows.Count != 0)
            {
                var dataViewRow = (DataRowView)publicacionesDataGridView.SelectedRows[0].DataBoundItem;
                var publicacion = new PublicacionRepository().parse(dataViewRow.Row);
                if (publicacion.estado.Descripcion_Estado.Equals("Borrador"))
                {
                    var vistaModificar = new GenerarPublicaciones();
                    vistaModificar.ShowDialog(new PublicacionRepository().parse(dataViewRow.Row));
                }
                else
                {
                    MessageBox.Show("Solo puede editar publicaciones en estado Borrardor");
                }
            }
            else MessageBox.Show("Debe seleccionar una publicacion para modificar");
        }

        private void activarButton_Click(object sender, EventArgs e)
        {
            if (publicacionesDataGridView.SelectedRows.Count != 0)
            {
                var dataViewRow = (DataRowView)publicacionesDataGridView.SelectedRows[0].DataBoundItem;
                var publicacion = new PublicacionRepository().parse(dataViewRow.Row);
                if (!publicacion.estado.Descripcion_Estado.Equals("Activa"))
                {
                    new PublicacionRepository().cambiarEstado(publicacion.Cod_Publicacion, "Activa");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La publicacion seleccionada ya esta activa");
                }
            }
            else MessageBox.Show("Debe seleccionar una publicacion para activar");
        }

        private void finalizarButton_Click(object sender, EventArgs e)
        {
            if (publicacionesDataGridView.SelectedRows.Count != 0)
            {
                var dataViewRow = (DataRowView)publicacionesDataGridView.SelectedRows[0].DataBoundItem;
                var publicacion = new PublicacionRepository().parse(dataViewRow.Row);
                new PublicacionRepository().cambiarEstado(publicacion.Cod_Publicacion, "Finalizado");
            }
            else MessageBox.Show("Debe seleccionar una publicacion para finalizar");
        }

        private void pausarButton_Click(object sender, EventArgs e)
        {
            if (publicacionesDataGridView.SelectedRows.Count != 0)
            {
                var dataViewRow = (DataRowView)publicacionesDataGridView.SelectedRows[0].DataBoundItem;
                var publicacion = new PublicacionRepository().parse(dataViewRow.Row);
                if (!publicacion.estado.Descripcion_Estado.Equals("Pausada"))
                {
                    new PublicacionRepository().cambiarEstado(publicacion.Cod_Publicacion, "Pausada");
                    MessageBox.Show("Publicacion pausada exitosamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La publicacion seleccionada ya esta pausada");
                }
            }
            else MessageBox.Show("Debe seleccionar una publicacion para pausar");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void activarButton_Click_1(object sender, EventArgs e)
        {
            if (publicacionesDataGridView.SelectedRows.Count != 0)
            {
                var dataViewRow = (DataRowView)publicacionesDataGridView.SelectedRows[0].DataBoundItem;
                var publicacion = new PublicacionRepository().parse(dataViewRow.Row);
                if (!publicacion.estado.Descripcion_Estado.Equals("Activa"))
                {
                    new PublicacionRepository().cambiarEstado(publicacion.Cod_Publicacion, "Activa");
                    MessageBox.Show("Publicacion activada exitosamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La publicacion seleccionada ya esta activa");
                }
            }
            else MessageBox.Show("Debe seleccionar una publicacion para activar");
        }

        private void finalizarButton_Click_1(object sender, EventArgs e)
        {
               if (publicacionesDataGridView.SelectedRows.Count != 0)
            {
                var dataViewRow = (DataRowView)publicacionesDataGridView.SelectedRows[0].DataBoundItem;
                var publicacion = new PublicacionRepository().parse(dataViewRow.Row);
                new PublicacionRepository().cambiarEstado(publicacion.Cod_Publicacion, "Finalizado");
                MessageBox.Show("Publicacion finalizada exitosamente");
                this.Close();
                
            }
            else MessageBox.Show("Debe seleccionar una publicacion para activar");
        }

        private void pausarButton_Click_1(object sender, EventArgs e)
        {
            if (publicacionesDataGridView.SelectedRows.Count != 0)
            {
                var dataViewRow = (DataRowView)publicacionesDataGridView.SelectedRows[0].DataBoundItem;
                var publicacion = new PublicacionRepository().parse(dataViewRow.Row);
                if (!publicacion.estado.Descripcion_Estado.Equals("Pausada"))
                {
                    new PublicacionRepository().cambiarEstado(publicacion.Cod_Publicacion, "Pausada");
                    MessageBox.Show("Publicacion pausada exitosamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La publicacion seleccionada ya esta pausada");
                }
            }
            else MessageBox.Show("Debe seleccionar una publicacion para pausar");
        }
    }
}
