using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
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

        public Publicaciones parse(DataRow dr)
        {
            return new Publicaciones(
                Convert.ToInt32(dr["Cod_Publicacion"]),
                Convert.ToInt32(dr["Cod_Publicacion_Anterior"]),
                dr["Descripcion_Publicacion"] as string,
                Convert.ToInt32(dr["Stock_Publicacion"]),
                Convert.ToDateTime(dr["Fecha_Publicacion"]),
                Convert.ToDateTime(dr["Fecha_Vencimiento_Publicacion"]),
                Convert.ToInt32(dr["Precio_Publicacion"]),
                new TipoPublicacionRepository().getTipoPublicaciones( Convert.ToInt32( dr["Cod_Tipos_Publicacion"] )),
                new RubroRepository().getRubro( Convert.ToInt32(dr["Cod_Rubro"]) ),
                new VisibilidadRepository().getVisibilidad(Convert.ToInt32(dr["Cod_Visibilidad"])),
                Convert.ToInt32(dr["Costo_Publicacion"]),
                new UsuariosRepository().getUsuario( Convert.ToInt32( dr["Cod_Usuario_Responsable"] )),
                new EstadoPublicacionesRepository().getEstadoPublicaciones(Convert.ToInt32(dr["Cod_Estado_Publicacion"])),
                (Boolean)dr["Permiso_Preguntas"],
                (Boolean)dr["Entregas"]
            );
        }
    }
}
