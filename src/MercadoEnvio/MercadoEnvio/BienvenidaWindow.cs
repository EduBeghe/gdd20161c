using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.UI;

namespace MercadoEnvio
{
    public partial class BienvenidaWindow : Form
    {
        public BienvenidaWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            new LoginScreen().ShowDialog(this);
            this.Close();
        }
    }
}
