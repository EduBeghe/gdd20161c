using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Domain;
using MercadoEnvio.Utils;

namespace MercadoEnvio.Repositories
{
    class PublicacionesRepository
    {

        
        public int getTipoDePublicacionIDPorDescripcion(string descripcion)
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Obtener_Tipo_De_Publicacion", descripcion);
            return retorno;
        }
    }
}
