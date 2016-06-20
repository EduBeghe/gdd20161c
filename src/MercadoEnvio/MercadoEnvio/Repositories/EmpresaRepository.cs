using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MercadoEnvio.Domain;
using MercadoEnvio.Utils;
using System.Data;

namespace MercadoEnvio.Repositories
{
    class EmpresaRepository
    {
        public DetalleEmpresa getClienteByUserId(int uID)
        {
            return parse(DBAdapter.retrieveDataTable("obtenerEmpresaPorCodigoUsuario", uID).Rows[0]);
        }

        public int altaEmpresa(DetalleEmpresa detalleEmpresa)
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Alta_Empresa", 
                detalleEmpresa.Razon_Social,
                detalleEmpresa.Mail,
                detalleEmpresa.Telefono,
                detalleEmpresa.domicilio.Calle,
                detalleEmpresa.domicilio.Nro_Calle,
                detalleEmpresa.domicilio.Piso,
                detalleEmpresa.domicilio.Depto,
                detalleEmpresa.domicilio.Localidad,
                detalleEmpresa.Cod_Postal,
                detalleEmpresa.Ciudad,
                detalleEmpresa.CUIT,
                detalleEmpresa.rubro,
                detalleEmpresa.Estado_Empresa
                );
            return retorno;
        }

        public int modificarEmpresa( string cuitViejo, string razonSocialVieja, DetalleEmpresa detalleEmpresa)
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Modificar_Empresa",
                cuitViejo, 
                razonSocialVieja,
                detalleEmpresa.Razon_Social,
                detalleEmpresa.Mail,
                detalleEmpresa.Telefono,
                detalleEmpresa.domicilio.Calle,
                detalleEmpresa.domicilio.Nro_Calle,
                detalleEmpresa.domicilio.Piso,
                detalleEmpresa.domicilio.Depto,
                detalleEmpresa.domicilio.Localidad,
                detalleEmpresa.Cod_Postal,
                detalleEmpresa.Ciudad,
                detalleEmpresa.CUIT,
                detalleEmpresa.rubro,
                detalleEmpresa.Estado_Empresa
                );
            return retorno;
        }

        private DetalleEmpresa parse(DataRow dr)
        {

            return new DetalleEmpresa(
                Convert.ToInt32(dr["Cod_Empresa"]),
                Convert.ToInt32(dr["Cod_Usuario"]),
                dr["Razon_Social"] as string,
                dr["Mail"] as string,
                Convert.ToInt32(dr["Telefono"]),
                new DomicilioRepository().getDomicilio(Convert.ToInt32(dr["Cod_Domicilio"])),
                dr["Cod_Postal"] as String,
                dr["Ciudad"] as String,
                dr["CUIT"] as String,
                // Rubro
                (Boolean)dr["Estado_Empresa"]
            );


        }

    }
}
