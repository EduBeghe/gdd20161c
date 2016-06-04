
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class Funcionalidades
    {
        int Cod_Funcionalidad { get; set; }
        string Descripcion_Funcionalidad { get; set; }

        public Funcionalidades( int Cod_Funcionalidad, string Descripcion_Funcionalidad )
        {
            this.Cod_Funcionalidad = Cod_Funcionalidad;
            this.Descripcion_Funcionalidad = Descripcion_Funcionalidad;
        } 
    }
}
