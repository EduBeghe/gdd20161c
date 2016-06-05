
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class Rubro
    {
        int codigo { get; set; }
        string descripcion { get; set; }
        string descripcion_rubro { get; set; }

        public Rubro( int codigo, string descripcion, string descripcion_rubro )
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.descripcion_rubro = descripcion_rubro;
        } 
    }
}
