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
using MercadoEnvio.Repositories;
using MercadoEnvio.Domain;
using MercadoEnvio.Repositories;

namespace MercadoEnvio.UI.ABM_Usuario
{
    public partial class AltaEmpresa : Form
    {
        string username;
        DetalleEmpresa empresa;
        bool modificando;

        public AltaEmpresa()
        {
            InitializeComponent();
        }

        internal void ShowDialog(DetalleEmpresa empresa)
        {
            this.modificando = true;
            this.empresa = empresa;
            this.FindForm().ShowDialog();
        }

        internal void ShowDialog(string username)
        {
            this.modificando = false;
            this.username = username;
            this.FindForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacion.validarInputs(this.Controls))
            {
                var retornoAlta = 1;
                if (this.modificando)
                {
                    retornoAlta = new EmpresaRepository().modificarEmpresa(
                        Convert.ToString(this.empresa.CUIT), 
                        this.empresa.Razon_Social, 
                        razonTextBox.Text, 
                        mailTextBox.Text, 
                        Convert.ToInt32(telefonoTextBox.Text), 
                        calleTextBox.Text, Convert.ToInt32(numeroCalleTextBox.Text), 
                        Convert.ToInt32(numeroPisoTextBox.Text), 
                        dptoTextBox.Text, localidadTextBox.Text, 
                        cpTextBox.Text, 
                        ciudadTextBox.Text, 
                        cuitTextBox.Text, 
                        rubroTextBox.Text,
                        true,
                        contactoTextBox.Text);
                } else
                {
                    retornoAlta = new EmpresaRepository().altaEmpresa(
                    razonTextBox.Text,
                    mailTextBox.Text,
                    Convert.ToInt32(telefonoTextBox.Text),
                    calleTextBox.Text,
                    Convert.ToInt32(numeroCalleTextBox.Text),
                    Convert.ToInt32(numeroPisoTextBox.Text),
                    dptoTextBox.Text,
                    localidadTextBox.Text,
                    cpTextBox.Text,
                    ciudadTextBox.Text,
                    cuitTextBox.Text,
                    rubroTextBox.Text,
                    true,
                    contactoTextBox.Text
                    );
                }
                if (retornoAlta == 0)
                {
                    MessageBox.Show("La empresa ha sido creada exitosamente.");
                }
                else
                {
                    MessageBox.Show("La empresa que quiere dar de alta ya existe.");
                }
            }
        }

        private void AltaEmpresa_Load(object sender, EventArgs e)
        {
            if (modificando)
            {
                razonTextBox.Text = empresa.Razon_Social;
                cuitTextBox.Text = Convert.ToString(empresa.CUIT);
                mailTextBox.Text = empresa.Mail;
                telefonoTextBox.Text = Convert.ToString(empresa.Telefono);
                calleTextBox.Text = empresa.domicilio.Calle;
                numeroCalleTextBox.Text = Convert.ToString(empresa.domicilio.Nro_Calle);
                numeroPisoTextBox.Text = Convert.ToString(empresa.domicilio.Piso);
                dptoTextBox.Text = empresa.domicilio.Depto;
                localidadTextBox.Text = empresa.domicilio.Localidad;
                cpTextBox.Text = empresa.Cod_Postal;
                ciudadTextBox.Text = empresa.Ciudad;
                contactoTextBox.Text = empresa.nombreContacto;
                rubroTextBox.Text = empresa.rubro.Descripcion_Rubro;
            }
        }

        private void telefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MercadoEnvio.Utils.Validacion.validateNumberTextBox(sender, e);
        }

        private void numeroCalleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MercadoEnvio.Utils.Validacion.validateNumberTextBox(sender, e);
        }

        private void numeroPisoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MercadoEnvio.Utils.Validacion.validateNumberTextBox(sender, e);
        }

        private void cpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MercadoEnvio.Utils.Validacion.validateNumberTextBox(sender, e);
        }
    }
}
