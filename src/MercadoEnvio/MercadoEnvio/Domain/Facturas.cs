using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
    class Facturas
    {
        int Cod_Facturas { get; set; }
        int Nro_Factura { get; set; }
        DateTime Fecha_Factura { get; set; }
        int Total_Factura { get; set; }
        Usuario Vendedor_Correspondiente { get; set; }
        FormasDePago Forma_De_Pago { get; set; }
        Publicaciones publicacion { get; set; }

        public Facturas(int Cod_Facturas, int Nro_Factura, DateTime Fecha_Factura, int Total_Factura, Usuario Vendedor_Correspondiente, Publicaciones publicacion, FormasDePago formaDePago )
        {
            this.Cod_Facturas = Cod_Facturas;
            this.Nro_Factura = Nro_Factura;
            this.Fecha_Factura = Fecha_Factura;
            this.Total_Factura = Total_Factura;
            this.Vendedor_Correspondiente = Vendedor_Correspondiente;
            this.Forma_De_Pago = formaDePago;
            this.publicacion = publicacion;
        } 
    }
}
