using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using MercadoEnvio.Domain;

using MercadoEnvio.Utils;

using System.Data;



namespace MercadoEnvio.Repositories
{

    class UsuariosRepository
    {

        private Usuario parse(DataRow dr)
        {

        return new Usuario(Convert.ToInt32(dr["Cod_Usuario"]),

           dr["Nombre_Usuario"] as string,

           dr["password"] as string,

           Convert.ToInt32(dr["Intentos_Login"]), 

           (Boolean) dr["Estado_Usuario"];

           // Agregar
           // domicilio
           // telefono
           // cod_postal
           // mail
           );

        }



    }

