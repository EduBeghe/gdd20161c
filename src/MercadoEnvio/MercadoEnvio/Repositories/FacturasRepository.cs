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
        public void generarFactura(
            int Cod_Publicacion,
            int cantidad,
            string descripcion_formaDePago,
            int dni,
            string cuit
            )
        {
            DBAdapter.executeProcedure( "Generar_Factura",
                Cod_Publicacion,
                cantidad,
                descripcion_formaDePago,
                dni,
                cuit
            );
        }

        public void consultaFacturas(DateTime fechaInicio, DateTime fechaFinal, double precioInicio, double precioFinal, int dni, string cuit )
        {
            DBAdapter.executeProcedure("Consulta_Facturas",
                dni,
                cuit,
                fechaInicio,
                fechaFinal,
                precioInicio,
                precioFinal
                );
        }
    }
}
