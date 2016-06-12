using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Utils;

namespace MercadoEnvio.Repositories
{
    class RubroRepository
    {
        public int getRubroIDPorDescripcion(string descripcion)
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Obtener_Rubro", descripcion);
            return retorno;
        }
    }
}
