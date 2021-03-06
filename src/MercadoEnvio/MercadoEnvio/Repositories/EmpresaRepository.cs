﻿using System;
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
        public DetalleEmpresa getEmpresaPorCodigoUsuario(int uID)
        {
            var rows = DBAdapter.retrieveDataTable("obtenerEmpresaPorCodigoUsuario", uID);
            if (rows.Rows.Count > 0)
            {
                return parse(rows.Rows[0]);
            }
            else
            {
                return null;
            }
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
                string rubro,
                bool Estado_Empresa,
                string nombreContacto
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
                rubro,
                Estado_Empresa,
                CLC_SessionManager.currentUser.Nombre_Usuario,
                nombreContacto
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
            string rubro,
            bool Estado_Empresa,
            string nombreContacto
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
                rubro,
                Estado_Empresa,
                nombreContacto
                );
            return retorno;
        }

        public List<DetalleEmpresa> filtrarEmpresas(string razonSocial, string cuit, string email)
        {
            var retorno = parseEmpresas(DBAdapter.retrieveDataTable("Filtrar_Usuarios_Empresa", razonSocial, cuit, email));
            return retorno;
        }

        private List<DetalleEmpresa> parseEmpresas(DataTable dataTable)
        {
            return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
        }

        public DetalleEmpresa parse(DataRow dr)
        {
            return new DetalleEmpresa(
                Convert.ToInt32(dr["Cod_Empresa"]),
                Convert.ToInt32(dr["Cod_Usuario"]),
                dr["Razon_Social"] as string,
                dr["Mail"] as string,
                Convert.ToInt32(dr["Telefono"]),
                new DomicilioRepository().getDomicilio(Convert.ToInt32(dr["Cod_Domicilio"])),
                dr["Cod_Postal"] as string,
                dr["Ciudad"] as string,
                dr["CUIT"] as string,
                (Boolean)dr["Estado_Empresa"],
                dr["Rubro"] as string,
                dr["Nombre_De_Contacto"] as string
            );

        }

        public void darDeBaja(int clienteID)
        {
            DBAdapter.executeProcedure("Baja_Empresa", clienteID);
        }

    }
}
