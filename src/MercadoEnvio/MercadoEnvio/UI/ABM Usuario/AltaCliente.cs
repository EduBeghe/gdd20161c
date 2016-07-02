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
using MercadoEnvio.Domain;
using MercadoEnvio.Repositories;

namespace MercadoEnvio.UI.ABM_Usuario
{
    public partial class AltaCliente : Form
    {
        DetallesClientes cliente;
        string username;
        bool modificando;

        public AltaCliente()
        {
            InitializeComponent();
        }

        internal void ShowDialog(DetallesClientes cliente)
        {
            this.cliente = cliente;
            this.modificando = true;
            this.FindForm().ShowDialog();
            PopulateFields();
        }

        internal void ShowDialog(string username)
        {
            this.modificando = false;
            this.username = username;
            this.FindForm().ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            if (modificando)
            {
                nombreTextBox.Text = cliente.Nombre;
                apellidoTextBox.Text = cliente.Apellido;
                dniTextBox.Text = Convert.ToString(cliente.DNI);
                mailTextBox.Text = cliente.Mail;
                telefonoTextBox.Text = Convert.ToString(cliente.Telefono);
                calleTextBox.Text = cliente.domicilio.Calle;
                numeroCalleTextBox.Text = Convert.ToString(cliente.domicilio.Nro_Calle);
                nroPisoTextBox.Text = Convert.ToString(cliente.domicilio.Piso);
                dptoTextBox.Text = cliente.domicilio.Depto;
                localidadTextBox.Text = cliente.domicilio.Localidad;
                cpTextBox.Text = cliente.Cod_Postal;
                fechaNacimientoDateTimePicker.Value = cliente.Fecha_Nacimiento;
                button1.Text = "Modificar";
            }
            else
            {
                button1.Text = "Crear";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacion.validarInputs(this.Controls))
            {
                var retornoAlta = 1;
                if (this.modificando)
                {
                    retornoAlta = new ClientesRepository().modificarCliente(
                        this.cliente.DNI,
                        nombreTextBox.Text,
                        apellidoTextBox.Text,
                        Convert.ToInt32(dniTextBox.Text),
                        mailTextBox.Text,
                        Convert.ToInt32(telefonoTextBox.Text),
                        calleTextBox.Text,
                        Convert.ToInt32(numeroCalleTextBox.Text),
                        Convert.ToInt32(nroPisoTextBox.Text),
                        dptoTextBox.Text,
                        localidadTextBox.Text,
                        cpTextBox.Text,
                        fechaNacimientoDateTimePicker.Value);
                }
                else
                {
                    retornoAlta = new ClientesRepository().altaCliente(
                        nombreTextBox.Text,
                        apellidoTextBox.Text,
                        Convert.ToInt32(dniTextBox.Text),
                        mailTextBox.Text,
                        Convert.ToInt32(telefonoTextBox.Text),
                        calleTextBox.Text,
                        Convert.ToInt32(nroPisoTextBox.Text),
                        dptoTextBox.Text,
                        Convert.ToInt32(numeroCalleTextBox.Text),
                        localidadTextBox.Text,
                        cpTextBox.Text,
                        fechaNacimientoDateTimePicker.Value,
                        this.username);
                }
                if (retornoAlta == 0)
                {
                    MessageBox.Show("El cliente ha sido creado exitosamente.");
                    this.Close();
                }
                else
                {
                    if (modificando)
                    {
                        MessageBox.Show("No se pudo modificar el cliente adecuadamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo dar de alta el cliente adecuadamente.");
                    }
                }
            }
        }

        private void PopulateFields()
        {
            nombreTextBox.Text = this.cliente.Nombre;
            apellidoTextBox.Text = this.cliente.Apellido;
            dniTextBox.Text = Convert.ToString(this.cliente.DNI);
            mailTextBox.Text = this.cliente.Mail;
            telefonoTextBox.Text = Convert.ToString(this.cliente.Telefono);
            calleTextBox.Text = this.cliente.domicilio.Calle;
            nroPisoTextBox.Text = Convert.ToString(this.cliente.domicilio.Piso);
            dptoTextBox.Text = Convert.ToString(this.cliente.domicilio.Depto);
            numeroCalleTextBox.Text = Convert.ToString(this.cliente.domicilio.Nro_Calle);
            localidadTextBox.Text = this.cliente.domicilio.Localidad;
            cpTextBox.Text = Convert.ToString(this.cliente.Cod_Postal);
            fechaNacimientoDateTimePicker.Value = this.cliente.Fecha_Nacimiento;
        }

        private void dniTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MercadoEnvio.Utils.Validacion.validateNumberTextBox(sender, e);
        }

        private void tipoDocumentoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MercadoEnvio.Utils.Validacion.validateNumberTextBox(sender, e);
        }

        private void telefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MercadoEnvio.Utils.Validacion.validateNumberTextBox(sender, e);
        }

        private void numeroCalleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MercadoEnvio.Utils.Validacion.validateNumberTextBox(sender, e);
        }

        private void nroPisoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MercadoEnvio.Utils.Validacion.validateNumberTextBox(sender, e);
        }

        private void mailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
