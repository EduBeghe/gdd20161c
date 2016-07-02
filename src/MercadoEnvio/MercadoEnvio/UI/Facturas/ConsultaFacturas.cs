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

namespace MercadoEnvio.Facturas
{
    public partial class ConsultaFacturas : Form
    {
        public ConsultaFacturas()
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

        private void button1_Click(object sender, EventArgs e)
        {
            new FacturasRepository().consultaFacturas(
            Convert.ToDateTime(this.DesdeDateTimePicker.Value ),
            Convert.ToDateTime( this.hastaDateTimePicker.Value ),
            Convert.ToInt32( this.importeInicialTextBox.Text ),
            Convert.ToInt32( this.importeFinalTextBox ),
            CLC_SessionManager.getDNI(),
            CLC_SessionManager.getCUIT()            
            );
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
