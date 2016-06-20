﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercadoEnvio.UI.ABM_Rol;
using MercadoEnvio.ABM_Rol;
using MercadoEnvio.ABM_Usuario;

namespace MercadoEnvio.UI.Menu
{
    public partial class FunctionsMenu : Form
    {
        public FunctionsMenu()
        {
            InitializeComponent();
        }

        internal void ShowDialog()
        {
            this.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Listado().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AltaRol().ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AltaUsuario().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new BuscadorUsuarios().ShowDialog();
        }

        private void FunctionsMenu_Load(object sender, EventArgs e)
        {

        }
    }
}