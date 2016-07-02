using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Domain;
using MercadoEnvio.Utils;
using System.Data;

namespace MercadoEnvio.Repositories
{
    class CalificarRepository
    {
        public int calificarCompra(int estrellas, int codCompra, string descripcion)
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Calificar_Compra", 
                estrellas,
                codCompra,
                descripcion
            );
            return retorno;
        }

            public Calificaciones getCalificacion(int calificacionID)
            {
                return parse(DBAdapter.retrieveDataTable("Get_Calificacion", calificacionID).Rows[0]);
            }

        public Calificaciones parse( DataRow dr )
        {
            return new Calificaciones(
                Convert.ToInt32(dr["Cod_Calificacion"]),
                Convert.ToInt32(dr["Cantidad_Estrella"]),
                Convert.ToInt32(dr["Peso"]),
                dr["Descripcion"] as String
                );
        }


    }
}
