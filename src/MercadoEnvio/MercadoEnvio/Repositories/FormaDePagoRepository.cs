using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Utils;

namespace MercadoEnvio.Repositories
{
    class FormaDePagoRepository
    {
        public int getFormaDePagoIDPorDescripcion(string descripcion)
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Obtener_Forma_De_Pago", descripcion);
            return retorno;
        }
    }
}
