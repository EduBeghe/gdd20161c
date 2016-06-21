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
        public void altaPublicaciones(
               string Descripcion_Publicacion,
               int Stock_Publicacion,
               DateTime Fecha_Publicacion,
               DateTime Fecha_Vencimiento_Publicacion,
               int Precio_Publicacion,
               string Tipo_Publicacion,
               string rubro,
               string visibilidadPublicaciones,
               int Costo_Publicacion,
               int dni,
               string cuit,
               string estado,
               bool Permiso_Preguntas,
               bool Entregas)
        {
            DBAdapter.executeProcedure( "Alta_Publicacion",
               Descripcion_Publicacion,
               Stock_Publicacion,
               Fecha_Publicacion,
               Fecha_Vencimiento_Publicacion,
               Precio_Publicacion,
               Tipo_Publicacion,
               rubro,
               visibilidadPublicaciones,
               Costo_Publicacion,
               dni,
               cuit,
               estado,
               Permiso_Preguntas,
               Entregas
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
