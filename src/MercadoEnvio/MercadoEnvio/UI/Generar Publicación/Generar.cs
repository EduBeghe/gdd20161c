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

namespace MercadoEnvio.Generar_Publicación
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

        }

        private void button1_Click(object sender, EventArgs e)
        {

            new PublicacionRepository().altaPublicaciones( 
                this.descripcionTextBox.Text,
                Convert.ToInt32( this.stockTextBox.Text ),
                Convert.ToDateTime( this.inicioDateTimePicker.Value ),
                Convert.ToDateTime( this.vencimientoDateTimePicker.Value ),
                Convert.ToInt32( this.precioTextBox.Text ),
                ((Tipos_Publicaciones)tipoPublicacionComboBox.SelectedItem).descripcion_Tipo,
                ((Rubros)rubroComboBox.SelectedItem).Descripcion_Rubro,
                ((VisibilidadPublicaciones)visibilidadComboBox.SelectedItem).Descripcion_Visibilidad,
                CLC_SessionManager.getDNI(),
                CLC_SessionManager.getCUIT(),
                ((EstadosPublicaciones)estadoComboBox.SelectedItem).Descripcion_Estado,
                this.permitirPreguntasCheckBox.Checked,
                // Agregar 
                true
                );
        }
    }
}
