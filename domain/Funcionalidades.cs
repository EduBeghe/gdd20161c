
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class Funcionalidades
    {
        int codigo { get; set; }
        string descripcion { get; set; }

        public Funcionalidades( int codigo, string descripcion )
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
        } 
    }
}
