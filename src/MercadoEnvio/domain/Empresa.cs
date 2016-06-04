using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DateTime;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class Empresa : Usuario
    {
        public string razon_social { get; set; }
        public string ciudad { get; set; }
        public int cuit { get; set; }
        public string nombre_contacto { get; set; }
        public Rubro rubro { get; set; }
        
        public Usuario( string razon_social, stirng ciudad, int cuit, string nombre_contacto, Rubro rubro )
        {
            this.razon_social = razon_social;
            this.ciudad = ciudad;
            this.cuit = cuit;
            this.nombre_contacto = nombre_contacto;
            this.rubro = rubro;
        }

    }
}
