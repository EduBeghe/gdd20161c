using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DateTime;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class Cliente : Usuario
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int DNI { get; set; }
        public string tipo_documento { get; set; }
        public DateTime nacimiento { get; set; }
        public DateTime creacion { get; set; }
        
        public Usuario( string nombre, string apellido, int DNI, string tipo_documento, DateTime nacimiento, DateTime creacion  )
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.DNI = DNI;     
            this.tipo_documento = tipo_documento;
            this.nacimiento = nacimiento;
            this.creacion = creacion;
        }

    }
}
