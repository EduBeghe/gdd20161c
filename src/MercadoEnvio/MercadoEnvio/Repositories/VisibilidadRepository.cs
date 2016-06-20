using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Domain;
using MercadoEnvio.Utils;
using MercadoEnvio.Domain.VisibilidadPublicaciones; 

namespace MercadoEnvio.Repositories
{
    class VisibilidadRepository
    {

        public int altaVisibilidad( string Descripcion_Visibilidad, int Precio_Visibilidad, int Porcentaje, int Comision_Entregas )
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Alta_Visibilidad",
                Descripcion_Visibilidad,
                Precio_Visibilidad,
                Porcentaje,
                Comision_Entregas
                );
            return retorno;
        }

        public void modificarVisibilidad(VisibilidadPublicaciones visibilidad)
        {
            DBAdapter.executeProcedure("Modificacion_Visibilidad",
                visibilidad.Cod_Visibilidad,
                visibilidad.Descripcion_Visibilidad,
                visibilidad.Precio_Visibilidad,
                visibilidad.Porcentaje,
                visibilidad.Comision_Entregas);
        }

        public void bajaVisibilidad(VisibilidadPublicaciones visibilidad)
        {
            DBAdapter.executeProcedure("Baja_Visibilidad",
                visibilidad.Cod_Visibilidad );
        }

    }
}
