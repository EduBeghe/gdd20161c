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
        int Cod_Domicilio { get; set;} 
        string Calle { get; set;} 
        int Piso { get; set;}
        string Depto { get; set;}
        int Nro_Calle { get; set;}
        string Localidad { get; set; }

        public Domicilio( int Cod_Domicilio, string Calle, int Piso, string Depto, int Nro_Calle, string Localidad )
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
