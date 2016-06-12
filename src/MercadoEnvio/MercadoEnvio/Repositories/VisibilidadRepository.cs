using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Utils;

namespace MercadoEnvio.Repositories
{
    class VisibilidadRepository
    {

        public int getVisibilidadIDPorDescripcion(string descripcion)
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Obtener_Visibilidad", descripcion);
            return retorno;
        }

    }
}
