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

        private Domicilio parse(DataRow dr)
        {

        return new Domicilio(

          Convert.ToInt32(dr["Cod_Domicilio"]),

          dr["Calle"] as string,

          Convert.ToInt32( dr["Piso"]),

          dr["Depto"] as string,

          dr["Nro_Calle"] as string,

          dr["Localidad"] as string;

           );

        }



    }

