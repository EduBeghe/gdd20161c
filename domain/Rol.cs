
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class Rol
    {
        int codigo { get; set; }
        string nombre { get; set; }
        bool estado { get; set; }

        public Rol( int codigo, string nombre, bool estado )
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.estado = estado;
        } 
    }
}
