
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class ItemsFacturas
    {
        int codigo { get; set; }
        Factura factura { get; set; }
        int itemFacturaCantidad { get; set; }
        int itemFacturaMonto { get; set; }

        public ItemsFacturas( int codigo, Factura factura, int itemFacturaMonto, 
            int itemFacturaCantidad )
        {
            this.codigo = codigo;
            this.factura = factura;
            this.itemFacturaMonto = itemFacturaMonto;
            this.itemFacturaCantidad = itemFacturaCantidad;
        } 
    }
}
