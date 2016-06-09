using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Domain;

namespace MercadoEnvio.Domain
{
    class Ofertas
    {
        int Cod_Oferta { get; set; }
        DateTime Oferta_Fecha { get; set; }
        int Oferta_Monto { get; set; }
        Publicaciones publicacion { get; set; }
        Usuario usuario { get; set; }

        public Ofertas(
            int Cod_Oferta,
            DateTime Oferta_Fecha,
            int Oferta_Monto,
            Publicaciones publicacion,
            Usuario usuario
        )
        {
            this.Cod_Oferta = Cod_Oferta;
            this.Oferta_Fecha = Oferta_Fecha;
            this.Oferta_Monto = Oferta_Monto;
            this.publicacion = publicacion;
            this.usuario = usuario;
        }


    }
}
