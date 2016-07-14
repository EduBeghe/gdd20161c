using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
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

            if (dni != 0)
            {
                DBAdapter.executeProcedure("Consulta_Facturas",
                    dni,
                    null,
                    fechaInicio,
                    fechaFinal,
                    precioInicio,
                    precioFinal
                    );
            }
            else
            {
                DBAdapter.executeProcedure("Consulta_Facturas",
                   null,
                   cuit,
                   fechaInicio,
                   fechaFinal,
                   precioInicio,
                   precioFinal
                   );
            }

        }

        public DataTable filtrarConsultasPaginado(int dni, string cuit, DateTime fechaInicio, DateTime fechaFinal, int precioInicio, int precioFinal, int pagina)
        {
            var retorno = DBAdapter.retrieveDataTable("Consulta_Facturas_Paginado", dni, cuit, fechaInicio, fechaFinal, precioInicio, precioFinal, pagina);
            return retorno;
        }

        public int getCantidadResultados(int dni, string cuit, DateTime fechaInicio, DateTime fechaFinal, int precioInicio, int precioFinal)
        {
            return DBAdapter.executeProcedureWithReturnValue("Cantidad_Facturas_Consultadas",dni, cuit, fechaInicio, fechaFinal, precioInicio, precioFinal);
        }
    }
}
