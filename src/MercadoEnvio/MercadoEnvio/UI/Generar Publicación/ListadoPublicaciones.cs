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
            this.publicacionesBindingSource.DataSource = DBAdapter.retrieveDataTable("Publicaciones_Modificables", CLC_SessionManager.getDNI(), CLC_SessionManager.getCUIT() );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (publicacionesDataGridView.SelectedRows.Count != 0)
            {
                var dataViewRow = (DataRowView)publicacionesDataGridView.SelectedRows[0].DataBoundItem;
                var publicacion = new PublicacionRepository().parse(dataViewRow.Row);
                new PublicacionRepository().modificarPublicacion(
                    publicacion.Cod_Publicacion,
                    publicacion.Descripcion_Publicacion,
                    publicacion.Stock_Publicacion,
                    publicacion.Fecha_Publicacion,
                    publicacion.Fecha_Vencimiento_Publicacion,
                    publicacion.Precio_Publicacion,
                    publicacion.tipoPublicacion.descripcion_Tipo, // string de subasta/compra inmediata
                    publicacion.rubro.Descripcion_Rubro,
                    publicacion.visibilidadPublicaciones.Descripcion_Visibilidad,
                    CLC_SessionManager.getDNI(),
                    CLC_SessionManager.getCUIT(),
                    publicacion.estado.Descripcion_Estado, // Este es el string del tipo de publicacion ( pausada, borrado... ) 
                    publicacion.Permiso_Preguntas,
                    publicacion.Entregas
                    );
                // MENSAJE DE ALGO
                //MessageBox.Show("Rol eliminado con exito");
                this.Close();
            }
            else MessageBox.Show("Debe seleccionar un rol para dar de baja");
        }
    }
}
