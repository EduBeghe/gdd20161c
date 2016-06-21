using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MercadoEnvio.Domain;
using MercadoEnvio.Utils;
using System.Data;

namespace MercadoEnvio.Repositories
{
    class RubroRepository
    {
        public int getRubroIDPorDescripcion(string descripcion)
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Obtener_Rubro", descripcion);
            return retorno;
        }

        public Rubros getRubros()
        {
            return parse(DBAdapter.retrieveDataTable("Get_Rubros").Rows[0]);
        }

        public Rubros getRubro( int rubroID )
        {
            return parse(DBAdapter.retrieveDataTable("Get_Rubro", rubroID).Rows[0]);
        }

        private Rubros parse(DataRow dr)
        {
            return new Rubros(
                Convert.ToInt32(dr["Cod_Rubro"]),
                dr["Descripcion_Breve"] as String,
                dr["Descripcion_Rubro"] as String
            );

        }

    }
}
