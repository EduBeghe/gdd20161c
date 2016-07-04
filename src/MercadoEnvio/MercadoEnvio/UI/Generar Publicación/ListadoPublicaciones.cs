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
                var estado = dataViewRow.Row["Descripcion_Estado"];
                var codigoPublicacion = Convert.ToInt32(dataViewRow.Row["Cod_Publicacion"]);
                if (estado.Equals("Borrador"))
                {
                    var vistaModificar = new GenerarPublicaciones();
                    vistaModificar.ShowDialog(codigoPublicacion);
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
                var estado = dataViewRow.Row["Descripcion_Estado"];
                var codigoPublicacion = Convert.ToInt32(dataViewRow.Row["Cod_Publicacion"]);
                if (!estado.Equals("Activa"))
                {
                    new PublicacionRepository().cambiarEstado(codigoPublicacion, "Activa");
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
                var codigoPublicacion = Convert.ToInt32(dataViewRow.Row["Cod_Publicacion"]);
                new PublicacionRepository().cambiarEstado(codigoPublicacion, "Finalizado");
            }
            else MessageBox.Show("Debe seleccionar una publicacion para finalizar");
        }

        private void pausarButton_Click(object sender, EventArgs e)
        {
            if (publicacionesDataGridView.SelectedRows.Count != 0)
            {
                var dataViewRow = (DataRowView)publicacionesDataGridView.SelectedRows[0].DataBoundItem;
                var estado = dataViewRow.Row["Descripcion_Estado"];
                var codigoPublicacion = Convert.ToInt32(dataViewRow.Row["Cod_Publicacion"]);
                if (!estado.Equals("Pausada"))
                {
                    new PublicacionRepository().cambiarEstado(codigoPublicacion, "Pausada");
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
                var estado = dataViewRow.Row["Descripcion_Estado"];
                var codigoPublicacion = Convert.ToInt32(dataViewRow.Row["Cod_Publicacion"]);
                if (!estado.Equals("Activa"))
                {
                    new PublicacionRepository().cambiarEstado(codigoPublicacion, "Activa");
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
                var codigoPublicacion = Convert.ToInt32(dataViewRow.Row["Cod_Publicacion"]);
                new PublicacionRepository().cambiarEstado(codigoPublicacion, "Finalizado");
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
                var estado = dataViewRow.Row["Descripcion_Estado"];
                var codigoPublicacion = Convert.ToInt32(dataViewRow.Row["Cod_Publicacion"]);
                if (!estado.Equals("Pausada"))
                {
                    new PublicacionRepository().cambiarEstado(codigoPublicacion, "Pausada");
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
