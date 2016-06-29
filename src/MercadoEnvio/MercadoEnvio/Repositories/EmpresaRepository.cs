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

        public int altaEmpresa(
                string Razon_Social,
                string Mail,
                int Telefono,
                string Calle,
                int Nro_Calle,
                int Piso,
                string Depto,
                string Localidad,
                string Cod_Postal,
                string Ciudad,
                string CUIT,
                string descripcion_rubro,
                bool Estado_Empresa
            )
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Alta_Empresa", 
                Razon_Social,
                Mail,
                Telefono,
                Calle,
                Nro_Calle,
                Piso,
                Depto,
                Localidad,
                Cod_Postal,
                Ciudad,
                CUIT,
                descripcion_rubro,
                Estado_Empresa
                );
            return retorno;
        }

        public int modificarEmpresa( 
            string cuitViejo, 
            string razonSocialVieja,
            string Razon_Social,
            string Mail,
            int Telefono,
            string Calle,
            int Nro_Calle,
            int Piso,
            string Depto,
            string Localidad,
            string Cod_Postal,
            string Ciudad,
            string CUIT,
            string descripcion_rubro,
            bool Estado_Empresa
            )
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Modificar_Empresa",
                cuitViejo, 
                razonSocialVieja,
                Razon_Social,
                Mail,
                Telefono,
                Calle,
                Nro_Calle,
                Piso,
                Depto,
                Localidad,
                Cod_Postal,
                Ciudad,
                CUIT,
                descripcion_rubro,
                Estado_Empresa
                );
            return retorno;
        }

        public List<DetalleEmpresa> filtrarEmpresas(string razonSocial, string cuit, string email)
        {
            var retorno = parseEmpresas(DBAdapter.retrieveDataTable("Filtrar_Usuarios_Empresas", razonSocial, cuit, email));
            return retorno;
        }

        private List<DetalleEmpresa> parseEmpresas(DataTable dataTable)
        {
            return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
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
                (Boolean)dr["Estado_Empresa"],
                new RubroRepository().getRubro(Convert.ToInt32(dr["Cod_Rubro"]))
            );

        }

        public void darDeBaja(int clienteID)
        {
            DBAdapter.executeProcedure("Baja_Empresa", clienteID);
        }

    }
}
