using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MercadoEnvio.Domain;
using MercadoEnvio.Utils;
using System.Data;

namespace MercadoEnvio.Repositories
{

    class FacturaRepository
    {

        private Factura parse(DataRow dr)
        {

        return new Factura(

          Convert.ToInt32(dr["Cod_Facturas"]),
          
          Convert.ToInt32(dr["Nro_Factura"]),

          Convert.ToDateTime(dr["Fecha_Factura"]),

          Convert.ToInt32(dr["Total_Factura"]),

          new UsuarioRepository.getUsuario( Convert.ToInt32(dr["Vendedor_Correspondiente"]) ),

          new FormasDePagoRepository.getFormasDePago( Convert.ToInt32(dr["Cod_Forma_De_Pago"]) ),

          new PublicacionRepository.getPublicacion( Convert.ToInt32(dr["Cod_Publicacion"]) ),

           );

        }
    } 
}

