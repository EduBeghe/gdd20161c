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

namespace MercadoEnvio.Historial_Cliente
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Validacion.estaVacio(filtroComboBox, "Filtro"))
            {
                switch (filtroComboBox.SelectedIndex)
                {
                    case 0:
                        {
                            this.historialDataGridView.DataSource = DBAdapter.retrieveDataTable("Historial_Cliente_Compras_Y_Ofertas", CLC_SessionManager.getDNI());
                            break;
                        }
                    case 1:
                        {
                            this.historialDataGridView.DataSource = DBAdapter.retrieveDataTable("Historial_Cliente_Calficaciones", CLC_SessionManager.getDNI());
                            break;
                        }
                }
            }
        }
    }
}