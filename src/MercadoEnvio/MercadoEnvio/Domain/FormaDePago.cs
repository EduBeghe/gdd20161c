
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class FormasDePago
    {
        int Cod_Formas_De_Pago { get; set; }
        string Descripcion_Forma { get; set; }

        public FormasDePago( int codigo, string descripcion )
        {
            this.Cod_Formas_De_Pago = Cod_Formas_De_Pago;
            this.Descripcion_Forma = descripcion;
        } 
    }
}
