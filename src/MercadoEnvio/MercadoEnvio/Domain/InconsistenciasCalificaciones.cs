using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
    class InconsistenciasCalificaciones
    {
        int Codigo_Anterior { get; set; }
        int Cantidad_Estrellas { get; set; }
        string Descripcion { get; set; }

        public InconsistenciasCalificaciones(
            int Codigo_Anterior,
            int Cantidad_Estrellas,
            string Descripcion
        )
        {
            this.Codigo_Anterior = Codigo_Anterior;
            this.Cantidad_Estrellas = Cantidad_Estrellas;
            this.Descripcion = Descripcion;
        }
    }
}
