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

            new PublicacionRepository().altaPublicaciones("Alta_Publicacion", 
                this.descripcionTextBox.Text,
                Convert.ToInt32( this.stockTextBox.Text ),
                Convert.ToDateTime( this.inicioDateTimePicker.Value ),
                Convert.ToDateTime( this.vencimientoDateTimePicker.Value ),
                Convert.ToInt32( this.precioTextBox.Text ),
                this.tipoPublicacionComboBox.SelectedItem,
                this.rubroComboBox.SelectedItem,
                this.visibilidadComboBox.SelectedItem,
                Convert.ToInt32( costo ),
                // dni
                // cuit
                this.estadoComboBox.SelectedItem,
                this.permitirPreguntasCheckBox.Checked

                );
        }
    }
}
