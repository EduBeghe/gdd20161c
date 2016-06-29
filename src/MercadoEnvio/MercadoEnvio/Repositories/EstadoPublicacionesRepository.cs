using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Domain;
using MercadoEnvio.Utils;
using System.Data;

namespace MercadoEnvio.Repositories
{
    class EstadoPublicacionesRepository
    {
        public EstadosPublicaciones parse(DataRow dr)
        {
            return new EstadosPublicaciones(
                Convert.ToInt32(dr["Cod_Estado"]),
                dr["Descripcion_Estado"] as String
          );
        }

        public EstadosPublicaciones getEstadoPublicaciones(int estadoPublicacionesID )
        {
            return parse(DBAdapter.retrieveDataTable("Get_Estado", estadoPublicacionesID).Rows[0]);
        }

    }
}
