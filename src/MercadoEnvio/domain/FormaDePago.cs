
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class FormasDePago
    {
        int codigo { get; set; }
        string descripcion { get; set; }

        public FormasDePago( int codigo, string descripcion )
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
        } 
    }
}
