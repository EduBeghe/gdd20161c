using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
    public class Facturas
    {
        public int Cod_Facturas { get; set; }
        public int Nro_Factura { get; set; }
        public DateTime Fecha_Factura { get; set; }
        public int Total_Factura { get; set; }
        public Usuario Vendedor_Correspondiente { get; set; }
        public FormasDePago Forma_De_Pago { get; set; }
        public Publicaciones publicacion { get; set; }

        public Facturas(int Cod_Facturas, int Nro_Factura, DateTime Fecha_Factura, int Total_Factura, Usuario Vendedor_Correspondiente, Publicaciones publicacion, FormasDePago formaDePago)
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
