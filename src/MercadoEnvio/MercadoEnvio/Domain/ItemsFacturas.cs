
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
        Facturas factura { get; set; }
        int Item_Factura_Cantidad { get; set; }
        int Item_Factura_Monto { get; set; }

        public ItemsFacturas( int codigo, Facturas factura, int itemFacturaMonto, 
            int itemFacturaCantidad )
        {
            this.codigo = codigo;
            this.factura = factura;
            this.Item_Factura_Monto = itemFacturaMonto;
            this.Item_Factura_Cantidad = itemFacturaCantidad;
        } 
    }
}
