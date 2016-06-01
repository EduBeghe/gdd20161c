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
        codigo { get; set} 
        string calle { get; set} 
        int piso { get; set}
        string departamento { get; set}
        int numero_calle { get; set} 
        string localidad { get; set}

        public Domicilio( string calle, int piso, string departamento, int numero_calle, string localidad )
        {
            this.calle = calle;
            this.piso = piso;
            this.departamento = departamento;
            this.numero_calle = numero_calle;
            this.localidad = localidad 
        }

    }
}
