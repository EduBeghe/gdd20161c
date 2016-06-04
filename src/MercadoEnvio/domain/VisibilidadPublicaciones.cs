
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class VisibilidadPublicaciones
    {
        int codigo { get; set; }
        string descripcionVisibilidad { get; set; }
        int precioVisibilidad { get; set; }
        int porcentaje { get; set; }

        public VisibilidadPublicaciones( int codigo, string descripcionVisibilidad, int porcentaje, 
            int precioVisibilidad )
        {
            this.codigo = codigo;
            this.descripcionVisibilidad = descripcionVisibilidad;
            this.porcentaje = porcentaje;
            this.precioVisibilidad = precioVisibilidad;
        } 
    }
}
