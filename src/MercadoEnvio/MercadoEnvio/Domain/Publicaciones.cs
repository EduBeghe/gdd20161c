using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class Publicaciones
    {
        int Cod_Publicacion { get; set; }
        int Cod_Publicacion_Anterior { get; set; }
        int Descripcion_Publicacion { get; set; }
        int Stock_Publicacion { get; set; }
        DateTime Fecha_Publicacion { get; set; }
        DateTime Fecha_Vencimiento_Publicacion { get; set; }
        int Precio_Publicacion { get; set; }
        int Cod_Tipos_Publicacion { get; set; }
        Rubros rubro { get; set; }
        VisibilidadPublicaciones visibilidadPublicaciones { get; set; }
        int Costo_Publicacion { get; set; }
        Usuario usuarioResponsable { get; set; }
        EstadosPublicaciones Cod_Estado_Publicacion { get; set; }
        bool Permiso_Preguntas { get; set; }
        bool Entregas { get; set; }

        public Publicaciones( 
            int Cod_Publicacion,
            int Cod_Publicacion_Anterior,
            int Descripcion_Publicacion,
            int Stock_Publicacion,
            DateTime Fecha_Publicacion,
            DateTime Fecha_Vencimiento_Publicacion,
            int Precio_Publicacion,
            int Cod_Tipos_Publicacion,
            Rubros rubro,
            VisibilidadPublicaciones visibilidadPublicaciones,
            int Costo_Publicacion,
            Usuario usuarioResponsable,
            EstadosPublicaciones Cod_Estado_Publicacion,
            bool Permiso_Preguntas, 
            bool Entregas )
        {
            this.Cod_Publicacion = Cod_Publicacion;
            this.Cod_Publicacion_Anterior = Cod_Publicacion_Anterior;
            this.Descripcion_Publicacion = Descripcion_Publicacion;
            this.Stock_Publicacion = Stock_Publicacion;
            this.Fecha_Publicacion = Fecha_Publicacion;
            this.Fecha_Vencimiento_Publicacion = Fecha_Vencimiento_Publicacion;
            this.Precio_Publicacion = Precio_Publicacion;
            this.Cod_Tipos_Publicacion = Cod_Tipos_Publicacion;
            this.rubro = rubro;
            this.visibilidadPublicaciones = visibilidadPublicaciones;
            this.Costo_Publicacion = Costo_Publicacion;
            this.usuarioResponsable = usuarioResponsable;
            this.Cod_Estado_Publicacion = Cod_Estado_Publicacion;
            this.Permiso_Preguntas = Permiso_Preguntas;
            this.Entregas = Entregas;
        }

    }
}
