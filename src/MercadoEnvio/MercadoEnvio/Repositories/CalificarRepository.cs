using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Domain;
using MercadoEnvio.Utils;

namespace MercadoEnvio.Repositories
{
    class CalificarRepository
    {
        public void calificarCompra(int estrellas, int codCompra, string descripcion)
        {
            DBAdapter.executeProcedure("Calificar_Compra", 
                estrellas,
                codCompra,
                descripcion
            );
        }

    }
}
