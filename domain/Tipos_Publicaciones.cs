
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class Tipos_Publicaciones
    {
        int cod_tipos_publicaciones { get; set; }
        string descripcion_Tipo { get; set; }

        public Tipos_Publicaciones( int cod_tipos_publicaciones, string descripcion_Tipo )
        {
            this.cod_tipos_publicaciones = cod_tipos_publicaciones;
            this.descripcion_Tipo = descripcion_Tipo;
        } 
    }
}
