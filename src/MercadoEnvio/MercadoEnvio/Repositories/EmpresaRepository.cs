using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoEnvio.Domain;
using MercadoEnvio.Utils;
using MercadoEnvio.Domain.Domicilio;

namespace MercadoEnvio.Repositories
{
    class EmpresaRepository
    {
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

    }
}
