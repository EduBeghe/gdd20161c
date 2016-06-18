using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Domain;
using MercadoEnvio.Utils;

namespace MercadoEnvio.Repositories
{
    class FacturasRepository
    {
        public void generarFactura(Domain.Facturas factura)
        {
            DBAdapter.executeProcedure( "Generar_Factura",
            factura.publicacion.Cod_Publicacion,
            factura.Total_Factura,
            factura.Forma_De_Pago
            // dni 
            // cuit
            );
        }

        public void consultaFacturas(DateTime fechaInicio, DateTime fechaFinal, double precioInicio, double precioFinal )
        {
            DBAdapter.executeProcedure("Consulta_Facturas",
                // dni
                // cuit
                fechaInicio,
                fechaFinal,
                precioInicio,
                precioFinal
                );
        }
    }
}
