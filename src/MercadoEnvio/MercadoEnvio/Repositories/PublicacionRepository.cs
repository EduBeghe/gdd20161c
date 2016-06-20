using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Domain;
using MercadoEnvio.Utils;

namespace MercadoEnvio.Repositories
{
    class PublicacionRepository
    {
        public void altaPublicaciones(Publicaciones publicacion)
        {
            DBAdapter.executeProcedure( "Alta_Publicacion",
                publicacion.Descripcion_Publicacion,
                publicacion.Stock_Publicacion,
                publicacion.Fecha_Publicacion,
                publicacion.Fecha_Vencimiento_Publicacion,
                publicacion.Precio_Publicacion,
                publicacion.tipoPublicacion,
                publicacion.rubro,
                publicacion.visibilidadPublicaciones,
                publicacion.Costo_Publicacion,
                // dni 
                // cuit
                publicacion.estado,
                publicacion.Permiso_Preguntas,
                publicacion.Entregas
                );
        }

        public void cambiarEstado(EstadosPublicaciones estadoPublicacion)
        {
            DBAdapter.executeProcedure( "Cambiar_Estado", 
                estadoPublicacion.Cod_Estado,
                estadoPublicacion
                );
        }

        public int comprarPublicacion(Publicaciones publicacion, int cantidad, string formaDePago )
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue( "Comprar_Publicacion",
                // dni
                // cuit
                publicacion.Cod_Publicacion,
                cantidad,
                formaDePago
                );
            return retorno;
        }

        public int ofertarPublicacion(Publicaciones publicacion, double oferta)
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Ofertar_Publicacion",
                // dni
                // cuit
                publicacion.Cod_Publicacion,
                oferta
            );
            return retorno;
        }

    }
}
