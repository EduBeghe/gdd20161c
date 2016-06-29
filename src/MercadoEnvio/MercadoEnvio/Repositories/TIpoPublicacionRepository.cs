using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MercadoEnvio.Domain;
using MercadoEnvio.Utils;
using System.Data;

namespace MercadoEnvio.Repositories
{
    class TipoPublicacionRepository
    {
        public Tipos_Publicaciones parse(DataRow dr)
        {
            return new Tipos_Publicaciones(
                Convert.ToInt32(dr["Cod_Tipos_Publicaciones"]),
                dr["Descripcion_Tipo"] as String
          );
        }

        public Tipos_Publicaciones getTipoPublicaciones( int tipoPublicacionID ) {
            return parse( DBAdapter.retrieveDataTable( "Get_Tipo_De_Publicacion", tipoPublicacionID ).Rows[0] );
        }
    }
}
