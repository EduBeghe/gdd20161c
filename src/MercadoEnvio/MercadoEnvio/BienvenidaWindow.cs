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

        internal void ShowDialog()
        {
            this.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            new UI.Login.LoginScreen().ShowDialog(this);
            this.Close();
        }

        private void BienvenidaWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
