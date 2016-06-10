
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class VisibilidadPublicaciones
    {
        int Cod_Visibilidad { get; set; }
        string Descripcion_Visibilidad { get; set; }
        int Precio_Visibilidad { get; set; }
        int Porcentaje { get; set; }
        int Comision_Entregas { get; set; }
        bool Estado_Visibilidad { get; set; }

        public VisibilidadPublicaciones(
            int Cod_Visibilidad,
            string Descripcion_Visibilidad,
            int Precio_Visibilidad,
            int Porcentaje,
            int Comision_Entregas,
            bool Estado_Visibilidad 
            )
        {
            this.Cod_Visibilidad = Cod_Visibilidad;
            this.Descripcion_Visibilidad = Descripcion_Visibilidad;
            this.Precio_Visibilidad = Precio_Visibilidad;
            this.Porcentaje = Porcentaje;
            this.Comision_Entregas = Comision_Entregas;
            this.Estado_Visibilidad = Estado_Visibilidad;
        } 
    }
}
