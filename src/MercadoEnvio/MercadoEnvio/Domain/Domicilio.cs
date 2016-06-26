using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class Domicilio
    {
        public int Cod_Domicilio { get; set; } 
        public string Calle { get; set;} 
        public int Piso { get; set;}
        public string Depto { get; set;}
        public int Nro_Calle { get; set;}
        public string Localidad { get; set; }

        public Domicilio(int Cod_Domicilio, string Calle, int Piso, string Depto, int Nro_Calle, string Localidad)
        {
            this.Cod_Domicilio = Cod_Domicilio;
            this.Calle = Calle;
            this.Piso = Piso;
            this.Depto = Depto;
            this.Nro_Calle = Nro_Calle;
            this.Localidad = Localidad; 
        }

    }
}
