using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
    class Compras
    {
        int Cod_Compra { get; set; }
        DateTime Compra_Fecha { get; set; }
        int Compra_Cantidad { get; set; }
        Publicaciones publicacion { get; set; }
        Usuario usuario { get; set; }
        Calificaciones calificacion { get; set; }
        int Cod_Calificacion_Anterior { get; set; }
        string Descripcion { get; set; }

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
