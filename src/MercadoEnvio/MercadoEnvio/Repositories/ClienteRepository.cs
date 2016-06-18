using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using MercadoEnvio.Domain;

using MercadoEnvio.Utils;

using System.Data;



namespace MercadoEnvio.Repositories
{

    class CLientesRepository
    {


        public void darDeBaja(Usuario usuario)
        {
            DBAdapter.executeProcedure("Baja_Usuario", usuario.Nombre_Usuario);
        }

        public void calificarCompra(Compras compra, int estrellas, string descripcion )
        {
            DBAdapter.executeProcedure("Calificar_Compra",
                estrellas,
                compra.Cod_Compra,
                descripcion
                );
        }

        public int altaCliente(string nombreUsuario, string password, int dni, string mail,
            int telefono, string calle, int numeroCalle, int piso, string depto, string localidad,
            string codPostal, DateTime fechaNacimiento)
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Alta_Cliente", nombreUsuario, password, dni, mail, telefono, calle, numeroCalle, piso, depto, localidad, codPostal, fechaNacimiento);
            return retorno;
        }


        public List<DetallesClientes> findClientes(string nombre, string apellido, TipoDocumento tipo_doc, string mail, int? nro_doc)
        {

            return parseClientes(DBAdapter.retrieveDataTable("find_clientes", nombre, apellido, tipo_doc.ID, mail, nro_doc));

        }

        public int modificarCliente( int dniViejo, string nombreUsuario, string password, int dni, string mail,
            int telefono, string calle, int numeroCalle, int piso, string depto, string localidad,
            string codPostal, DateTime fechaNacimiento)
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Modificar_Cliente", dniViejo, nombreUsuario, password, dni, mail, telefono, calle, numeroCalle, piso, depto, localidad, codPostal, fechaNacimiento);
            return retorno;
        }

        public List<DetallesClientes> getClientes()
        {
            return parseClientes(DBAdapter.retrieveDataTable("getCliente", DBNull.Value));
        }

        public DetallesClientes getCliente(int ID)
        {
            return parse(DBAdapter.retrieveDataTable("getCliente", ID).Rows[0]);
        }

        public DetallesClientes getClienteByUserId(int uID)
        {
            return parse(DBAdapter.retrieveDataTable("getClienteByUserId", uID).Rows[0]);
        }



        private List<DetallesClientes> parseClientes(DataTable dataTable)
        {

            return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();

        }



        private DetallesClientes parse(DataRow dr)
        {

            return new DetallesClientes(Convert.ToInt32(dr["Cod_Cliente"]),

                // Viejo, CAMBIAR!
                               dr["Nombre"] as string,

                               dr["Apellido"] as string,

                               new Documento(getTipoDoc(Convert.ToInt32(dr["Tipo_Documento"])), Convert.ToInt64(dr["Nro_Doc"])),

                               dr["Mail"] as string,
                               new Domicilio(dr["Dom_Calle"] as string, Convert.ToInt32(dr["Dom_Nro"]), dr["Dom_Depto"] as string, Convert.ToInt32(dr["Dom_Piso"]), dr["Localidad"] as string, new PaisRepository().getPais(Convert.ToInt32(dr["Pais"]))),
                               new PaisRepository().getPais(Convert.ToInt32(dr["Nacionalidad"])),
                               Convert.ToDateTime(dr["Fecha_nac"]),

                               (Boolean)dr["Estado"]);



        }





        public static bool coincideDocumento(long tipo, string documento)
        {

            return DBAdapter.checkIfExists("COINCIDE_DOCUMENTO", tipo, documento);

        }

        private TipoDocumento getTipoDoc(int p)
        {

            DataRow tipo = DBAdapter.retrieveDataTable("getTipoDoc", p).Rows[0];

            return new TipoDocumento(Convert.ToInt32(tipo["ID"]), tipo["Descripcion"] as string);

        }



        internal int darDeAlta(DetallesClientes cliente, Usuario usuario)
        {

            return DBAdapter.executeProcedureWithReturnValue("darDeAltaCliente",

            cliente.Nombre,

            cliente.Apellido,

            cliente.fechaNacimimento,

            cliente.mail,

            cliente.pais.Id,

            cliente.documento.ID,

            cliente.documento.tipo.ID,

            cliente.domicilio.calle,

            cliente.domicilio.numero,

            cliente.domicilio.departamento,

            cliente.domicilio.piso,

            cliente.domicilio.localidad,

            cliente.domicilio.nacionalidad.Id,

            usuario.nombre,

            usuario.password,

            usuario.preguntaSecreta,

            usuario.respuestaSecreta,

            usuario.fechaCreacion,

            usuario.fechaUltimaModificacion);



        }


        internal void modificar(DetallesClientes cliente)
        {
            DBAdapter.executeProcedureWithReturnValue("modificarCliente",

            cliente.ID,

            cliente.Nombre,

            cliente.Apellido,

            cliente.fechaNacimimento,

            cliente.mail,

            cliente.pais.Id,

            cliente.documento.ID,

            cliente.documento.tipo.ID,

            cliente.domicilio.calle,

            cliente.domicilio.numero,

            cliente.domicilio.departamento,

            cliente.domicilio.piso,

            cliente.domicilio.localidad,

            cliente.domicilio.nacionalidad.Id,

            cliente.estado);
        }
    }

}

