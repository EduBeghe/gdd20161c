using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DateTime;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class Domicilio
    {
        public string Calle { get; set;} 
        public int Piso { get; set;}
        public string Depto { get; set;}
        public int Nro_Calle { get; set;}
        public string Localidad { get; set; }

        public Domicilio( string Calle, int Piso, string Depto, int Nro_Calle, string Localidad )
        {
            this.Calle = Calle;
            this.Piso = Piso;
            this.Depto = Depto;
            this.Nro_Calle = Nro_Calle;
            this.Localidad = Localidad; 
        }

    }
}
