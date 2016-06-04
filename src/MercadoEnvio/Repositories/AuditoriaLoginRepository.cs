using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using MercadoEnvio.Domain;

using MercadoEnvio.Utils;

using System.Data;



namespace MercadoEnvio.Repositories
{

    class AuditoriaLoginRepository
    {

        private AuditoriaLogin parse(DataRow dr)
        {

        return new Domicilio(

          Convert.ToInt32(dr["Cod_Auditoria"]),

          new UsuarioRepository().getUsuario( Convert.ToInt32(dr["Cod_Usuario"]) ),

          Convert.ToDateTime(dr["Fecha"]),

          (bool) dr["Estado"]),

          Convert.ToInt32(dr["Numero_De_Intento"])
          
          );

        }



    }

}
