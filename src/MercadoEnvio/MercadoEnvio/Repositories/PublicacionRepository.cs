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

        public void modificarPublicacion(
            int Cod_Publicacion,
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
            DBAdapter.executeProcedure("Modificar_Publicacion",
              Cod_Publicacion,
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

        public void cambiarEstado(int codigoPublicacion, string estadoPublicacion)
        {
            DBAdapter.executeProcedure("Cambiar_Estado", 
                estadoPublicacion,
                codigoPublicacion
                );
        }

        public int comprarPublicacion(int dni, string cuit, int codigoPublicacion, int cantidad, string formaDePago )
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue( "Comprar_Publicacion", dni, cuit, codigoPublicacion, cantidad, formaDePago );
            return retorno;
        }

        public int ofertarPublicacion(int dni, string cuit, int codigoPublicacion, double oferta)
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Ofertar_Publicacion", dni, cuit, codigoPublicacion, oferta );
            return retorno;
        }

        public Publicaciones getPublicacion(int publicacionID)
        {
            return parse(DBAdapter.retrieveDataTable("Get_Publicacion", publicacionID).Rows[0]);
        }

        public List<Publicaciones> parsePublicaciones(DataTable dataTable)
        {
            return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
        }

        public DataTable filtrarPublicacionesPaginado(string rubro, string descripcion, int pagina, int dni, string cuit, string estado)
        {
            var retorno = DBAdapter.retrieveDataTable("Filtrar_Publicaciones_Paginado", rubro, descripcion, pagina, dni, cuit, estado);
            return retorno;
        }

        public int getCantidadPaginas(string rubro, string descripcion, int dni, string cuit)
        {
            return DBAdapter.executeProcedureWithReturnValue("Cantidad_Publicaciones_Filtradas", rubro, descripcion, dni, cuit);
        }

        public Publicaciones parse(DataRow dr)
        {
            return new Publicaciones(
                Convert.ToInt32(dr["Cod_Publicacion"]),
                0,
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
                dr["Permiso_Preguntas"] == null ? false : (Boolean)dr["Permiso_Preguntas"],
                dr["Entregas"]== null ? false : (Boolean)dr["Entregas"]
            );
        }

        
    }
}
