using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
    class Compras
    {
        public int Cod_Compra { get; set; }
        public DateTime Compra_Fecha { get; set; }
        public int Compra_Cantidad { get; set; }
        public Publicaciones publicacion { get; set; }
        public Usuario usuario { get; set; }
        public Calificaciones calificacion { get; set; }
        public int Cod_Calificacion_Anterior { get; set; }
        public string Descripcion { get; set; }

        public Compras(
            int Cod_Compra,
            DateTime Compra_Fecha,
            int Compra_Cantidad,
            Publicaciones publicacion,
            Usuario usuario,
            Calificaciones calificacion,
            int Cod_Calificacion_Anterior,
            string Descripcion
            )
        {
            this.Cod_Compra = Cod_Compra;
            this.Compra_Fecha = Compra_Fecha;
            this.Compra_Cantidad = Compra_Cantidad;
            this.publicacion = publicacion;
            this.usuario = usuario;
            this.calificacion = calificacion;
            this.Cod_Calificacion_Anterior = Cod_Calificacion_Anterior;
            this.Descripcion = Descripcion;
        }
    }
}
