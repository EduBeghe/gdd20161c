using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using MercadoEnvio.Domain;

using MercadoEnvio.Utils;

using System.Data;



namespace MercadoEnvio.Repositories
{
 
   class FuncionalidadesRepository
    {

        private Funcionalidades parse(DataRow dr)
        {

        return new Funcionalidades(

          Convert.ToInt32(dr["Cod_Funcionalidad"]),

          dr["Descripcion_Funcionalidad"] as string,
                    
          );

        }



    }

