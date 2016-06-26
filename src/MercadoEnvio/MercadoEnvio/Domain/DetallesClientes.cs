using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class DetallesClientes {
        public int Cod_Cliente { get; set; }
        public Usuario usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Mail { get; set; }
        public int Telefono { get; set; }
        public Domicilio domicilio { get; set; }
        public string Cod_Postal { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public bool Estado_Cliente { get; set; }

        public DetallesClientes(
            int Cod_Cliente,
            Usuario usuario,
            string Nombre,
            string Apellido,
            int DNI,
            string Mail,
            int Telefono,
            Domicilio domicilio,
            string Cod_Postal,
            DateTime Fecha_Nacimiento,
            DateTime Fecha_Creacion,
            bool Estado_Cliente
        )
        {
            this.Cod_Cliente = this.Cod_Cliente;
            this.usuario = usuario;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.DNI = DNI;
            this.Mail = Mail;
            this.Telefono = Telefono;
            this.domicilio = domicilio;
            this.Cod_Postal = Cod_Postal;
            this.Fecha_Nacimiento = Fecha_Nacimiento;
            this.Fecha_Creacion = Fecha_Creacion;
            this.Estado_Cliente = Estado_Cliente;
        }

    }
}
