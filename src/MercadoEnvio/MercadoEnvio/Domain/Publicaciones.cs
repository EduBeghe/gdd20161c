using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class Publicaciones
    {
        public int Cod_Publicacion { get; set; }
        public int Cod_Publicacion_Anterior { get; set; }
        public string Descripcion_Publicacion { get; set; }
        public int Stock_Publicacion { get; set; }
        public DateTime Fecha_Publicacion { get; set; }
        public DateTime Fecha_Vencimiento_Publicacion { get; set; }
        public int Precio_Publicacion { get; set; }
        public Tipos_Publicaciones tipoPublicacion { get; set; }
        public Rubros rubro { get; set; }
        public VisibilidadPublicaciones visibilidadPublicaciones { get; set; }
        public int Costo_Publicacion { get; set; }
        public Usuario usuarioResponsable { get; set; }
        public EstadosPublicaciones estado { get; set; }
        public bool Permiso_Preguntas { get; set; }
        public bool Entregas { get; set; }

        public Publicaciones( 
            int Cod_Publicacion,
            int Cod_Publicacion_Anterior,
            string Descripcion_Publicacion,
            int Stock_Publicacion,
            DateTime Fecha_Publicacion,
            DateTime Fecha_Vencimiento_Publicacion,
            int Precio_Publicacion,
            Tipos_Publicaciones tipoPublicacion,
            Rubros rubro,
            VisibilidadPublicaciones visibilidadPublicaciones,
            int Costo_Publicacion,
            Usuario usuarioResponsable,
            EstadosPublicaciones estado,
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
            this.tipoPublicacion = tipoPublicacion;
            this.rubro = rubro;
            this.visibilidadPublicaciones = visibilidadPublicaciones;
            this.Costo_Publicacion = Costo_Publicacion;
            this.usuarioResponsable = usuarioResponsable;
            this.estado = estado;
            this.Permiso_Preguntas = Permiso_Preguntas;
            this.Entregas = Entregas;
        }

    }
}
