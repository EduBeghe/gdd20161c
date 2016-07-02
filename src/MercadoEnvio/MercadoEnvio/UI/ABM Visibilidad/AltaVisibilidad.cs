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
using MercadoEnvio.Utils;

namespace MercadoEnvio.UI.ABM_Visibilidad
{
    public partial class AltaVisibilidad : Form
    {

        bool isEditing = true;
        int codigo;

        public AltaVisibilidad()
        {
            InitializeComponent();
        }


        internal void ShowDialog(bool algo)
        {
            this.isEditing = false;
            this.FindForm().ShowDialog();
        }

        internal void ShowDialog(int id)
        {
            this.codigo = id;
            this.isEditing = true;
            var visibilidad = new VisibilidadRepository().getVisibilidad(id);
            descripcionTextBox.Text = visibilidad.Descripcion_Visibilidad;
            precioTextBox.Text = Convert.ToString(visibilidad.Precio_Visibilidad);
            PorcentajeTextBox.Text = Convert.ToString(visibilidad.Porcentaje);
            comisionTextBox.Text = Convert.ToString(visibilidad.Comision_Entregas);
            this.FindForm().ShowDialog();
        }

        private void AltaVisibilidad_Load(object sender, EventArgs e)
        {
            if (this.isEditing)
            {
                button1.Text = "Modificar";
            }
            else 
            {
                button1.Text = "Crear";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( Validacion.validarInputs( this.Controls ) ) 
            {
                if(this.isEditing)
                {
                    var visibilidad = new VisibilidadPublicaciones(this.codigo,
                        this.descripcionTextBox.Text,
                        Convert.ToInt32(this.precioTextBox.Text),
                        Convert.ToInt32(this.PorcentajeTextBox.Text),
                        Convert.ToInt32(this.comisionTextBox.Text), true
                    );
                    new VisibilidadRepository().modificarVisibilidad(visibilidad);
                    MessageBox.Show("La visibildiad fue modificada existosamente");
                } 
                else 
                {
                    var retorno = new VisibilidadRepository().altaVisibilidad(
                        this.descripcionTextBox.Text,
                        Convert.ToInt32(this.precioTextBox.Text),
                        Convert.ToInt32(this.PorcentajeTextBox.Text),
                        Convert.ToInt32(this.comisionTextBox.Text)
                    );
                    if (retorno == -1) MessageBox.Show("La visibildiad que quiere dar de alta ya existe.");
                    else MessageBox.Show("La visibildiad fue dada de alta Existosamente");
                }
                this.Close();
            }
        }
    }
}
