
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class EstadosPublicaciones
    {
        public int Cod_Estado { get; set; }
        public string Descripcion_Estado { get; set; }

        public EstadosPublicaciones( int Cod_Estado, string Descripcion_Estado )
        {
            this.Cod_Estado = Cod_Estado;
            this.Descripcion_Estado = Descripcion_Estado;
        } 
    }
}
