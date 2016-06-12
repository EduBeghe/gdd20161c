using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Utils;

namespace MercadoEnvio.Repositories
{
    class EstadoRepository
    {
        public int getEstadoIDPorDescripcion(string descripcion)
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Obtener_Estado", descripcion);
            return retorno;
        }
    }
}
