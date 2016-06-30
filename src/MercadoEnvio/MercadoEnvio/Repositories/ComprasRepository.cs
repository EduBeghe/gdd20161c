using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Domain;
using System.Data;
using MercadoEnvio.Utils;

namespace MercadoEnvio.Repositories
{
    class ComprasRepository
    {

        public Compras getCompra(int compraID )
        {
            return parse(DBAdapter.retrieveDataTable("Get_Compra", compraID).Rows[0]);
        }

        private Compras parse(DataRow dr)
        {
            return new Compras(
            Convert.ToInt32(dr["Cod_Compra"]),
            Convert.ToDateTime(dr["Compra_Fecha"]),
            Convert.ToInt32(dr["Compra_Cantidad"]),
            new PublicacionRepository().getPublicacion( Convert.ToInt32(dr["Cod_Publicacion"]) ),
            new UsuariosRepository().getUsuario( Convert.ToInt32(dr["Cod_Usuario"]) ),
            new CalificarRepository().getCalificacion( Convert.ToInt32(dr["Cod_Calificacion"])),
            dr["Descripcion"] as String
            );
        }
    }
}
