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

        }

        private void button1_Click(object sender, EventArgs e)
        {

            new PublicacionRepository().altaPublicaciones( 
                this.descripcionTextBox.Text,
                Convert.ToInt32( this.stockTextBox.Text ),
                Convert.ToDateTime( this.inicioDateTimePicker.Value ),
                Convert.ToDateTime( this.vencimientoDateTimePicker.Value ),
                Convert.ToInt32( this.precioTextBox.Text ),
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
