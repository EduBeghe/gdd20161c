using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using MercadoEnvio.Domain;

using MercadoEnvio.Utils;

using System.Data;



namespace MercadoEnvio.Repositories
{

    class RolRepository
    {

        private Rol parse(DataRow dr)
        {

        return new Rol(

          Convert.ToInt32(dr["Cod_Rol"]),

          dr["Nombre"] as string,

          (Boolean) dr["Estado_Rol"],
          
          );

        }



    }

