using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using MercadoEnvio.Domain;

using MercadoEnvio.Utils;

using System.Data;



namespace MercadoEnvio.Repositories
{

    class DomicilioRepository
    {
        public Domicilio getDomicilio(int idDomicilio)
        {
            return parse(DBAdapter.retrieveDataTable("Get_Domicilio", idDomicilio).Rows[0]);
        }

        public List<Domicilio> getDomicilios()
        {
            return parseDomicilios(DBAdapter.retrieveDataTable("Get_Domicilios"));
        }

        public List<Domicilio> parseDomicilios(DataTable dataTable)
        {
            return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
        }

        private Domicilio parse(DataRow dr)
        {
            return new Domicilio(

              Convert.ToInt32(dr["Cod_Domicilio"]),

              dr["Calle"] as string,

              Convert.ToInt32(dr["Piso"]),

              dr["Depto"] as string,

              Convert.ToInt32(dr["Nro_Calle"]),

              dr["Localidad"] as string

            );

        }

    }
}
