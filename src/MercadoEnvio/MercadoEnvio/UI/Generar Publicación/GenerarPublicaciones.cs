using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.Repositories;
using MercadoEnvio.Domain;
using MercadoEnvio.Utils;

namespace MercadoEnvio.UI.Generar_Publicación
{
    public partial class GenerarPublicaciones : Form
    {
        Publicaciones publicacion;
        bool modificando = false;

        public GenerarPublicaciones()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.FindForm().ShowDialog();
        }

        internal void ShowDialog(int codigoPublicacion)
        {
            this.modificando = true;
            this.publicacion = new PublicacionRepository().getPublicacion(codigoPublicacion);
            this.FindForm().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2016DataSet13.Estados_Publicaciones' table. You can move, or remove it, as needed.
            this.estados_PublicacionesTableAdapter.Fill(this.gD1C2016DataSet13.Estados_Publicaciones);
            // TODO: This line of code loads data into the 'gD1C2016DataSet12.Visibilidades_Publicaciones' table. You can move, or remove it, as needed.
            this.visibilidades_PublicacionesTableAdapter.Fill(this.gD1C2016DataSet12.Visibilidades_Publicaciones);
            // TODO: This line of code loads data into the 'gD1C2016DataSet11.Rubros' table. You can move, or remove it, as needed.
            this.rubrosTableAdapter.Fill(this.gD1C2016DataSet11.Rubros);
            // TODO: This line of code loads data into the 'gD1C2016DataSet10.Tipos_Publicaciones' table. You can move, or remove it, as needed.
            this.tipos_PublicacionesTableAdapter.Fill(this.gD1C2016DataSet10.Tipos_Publicaciones);

            if (modificando)
            {
                this.descripcionTextBox.Text = publicacion.Descripcion_Publicacion;
                this.tipoPublicacionComboBox.SelectedItem = publicacion.tipoPublicacion;
                this.stockTextBox.Text = Convert.ToString( publicacion.Stock_Publicacion );
                this.inicioDateTimePicker.Value = publicacion.Fecha_Publicacion;
                this.vencimientoDateTimePicker.Value = publicacion.Fecha_Vencimiento_Publicacion;
                this.precioTextBox.Text = Convert.ToString( publicacion.Precio_Publicacion );
                this.rubroComboBox.SelectedItem = publicacion.rubro;
                this.visibilidadComboBox.SelectedItem = publicacion.visibilidadPublicaciones;
                this.estadoComboBox.SelectedItem = publicacion.estado;
                this.permitirEnvioCheckBox.Checked = publicacion.Permiso_Preguntas;
                this.permitirEnvioCheckBox.Checked = publicacion.Entregas;
                this.label11.Hide();
                this.estadoComboBox.Hide();
                button1.Text = "Modificar";
            }
            else
            {
                button1.Text = "Generar";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacion.validarInputs(this.Controls))
            {
                if (modificando)
                {
                    new PublicacionRepository().modificarPublicacion(
                        this.publicacion.Cod_Publicacion,
                        this.descripcionTextBox.Text,
                        Convert.ToInt32(this.stockTextBox.Text),
                        Convert.ToDateTime(this.inicioDateTimePicker.Value),
                        Convert.ToDateTime(this.vencimientoDateTimePicker.Value),
                        Convert.ToInt32(this.precioTextBox.Text),
                        tipoPublicacionComboBox.SelectedValue as String,
                        rubroComboBox.SelectedValue as String,
                        visibilidadComboBox.SelectedValue as String,
                        CLC_SessionManager.getDNI(),
                        CLC_SessionManager.getCUIT(),
                        publicacion.estado.Descripcion_Estado,
                        this.permitirPreguntasCheckBox.Checked,
                        this.permitirEnvioCheckBox.Checked
                        );
                    MessageBox.Show("Publicacion modificada exitosamente");
                    this.Close();
                }
                else
                {
                    new PublicacionRepository().altaPublicaciones(
                    this.descripcionTextBox.Text,
                    Convert.ToInt32(this.stockTextBox.Text),
                    Convert.ToDateTime(this.inicioDateTimePicker.Value),
                    Convert.ToDateTime(this.vencimientoDateTimePicker.Value),
                    Convert.ToInt32(this.precioTextBox.Text),
                    tipoPublicacionComboBox.SelectedValue as String,
                    rubroComboBox.SelectedValue as String,
                    visibilidadComboBox.SelectedValue as String,
                    CLC_SessionManager.getDNI(),
                    CLC_SessionManager.getCUIT(),
                    estadoComboBox.SelectedValue as String,
                    this.permitirPreguntasCheckBox.Checked,
                    this.permitirEnvioCheckBox.Checked
                    );
                    MessageBox.Show("Publicacion dada de Alta exitosamente");
                    this.Close();
                }
            }   
        }

        private void stock(object sender, KeyPressEventArgs e)
        {
            MercadoEnvio.Utils.Validacion.validateNumberTextBox(sender, e);
        }

        private void precio(object sender, KeyPressEventArgs e)
        {
            MercadoEnvio.Utils.Validacion.validateNumberTextBox(sender, e);
        }
    }
}
