
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class Rubros
    {
        public int Cod_Rubro { get; set; }
        public string Descripcion_Breve { get; set; }
        public string Descripcion_Rubro { get; set; }

        public Rubros( int codigo, string descripcion, string descripcion_rubro )
        {
            this.Cod_Rubro = codigo;
            this.Descripcion_Breve = descripcion;
            this.Descripcion_Rubro = descripcion_rubro;
        } 
    }
}
