using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Utils;

namespace MercadoEnvio.Repositories
{
    class CalificacionRepository
    {
        public int getCalificacionIDPorEstrellas(int cantidadEstrellas)
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Obtener_Calificacion", cantidadEstrellas );
            return retorno;
        }

        public void AgregarCalificacion(int cantidadDeEstrellas)
        {
            DBAdapter.executeProcedure("Agregar_Calificacion_Posible", cantidadDeEstrellas);
        }
    }
}
