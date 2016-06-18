using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoEnvio.UI.ABM_Rol
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Listado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD1C2016DataSet.Roles' Puede moverla o quitarla según sea necesario.
            this.rolesTableAdapter.Fill(this.gD1C2016DataSet.Roles);

        }
    }
}
