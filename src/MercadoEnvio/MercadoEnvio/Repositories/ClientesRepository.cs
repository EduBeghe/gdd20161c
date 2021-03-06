using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using MercadoEnvio.Domain;

using MercadoEnvio.Utils;

using System.Data;



namespace MercadoEnvio.Repositories
{

    class ClientesRepository
    {

        public void darDeBaja(int clienteID)
        {
            DBAdapter.executeProcedure("Baja_Cliente", clienteID );
        }

        public void calificarCompra(Compras compra, int estrellas, string descripcion )
        {
            DBAdapter.executeProcedure("Calificar_Compra",
                estrellas,
                compra.Cod_Compra,
                descripcion
                );
        }

        public int altaCliente(string nombre, string apellido, int dni, string mail,
            int telefono, string calle, int piso, string depto, int nro_calle, string localidad,
            string codPostal, DateTime fechaNacimiento, string username)
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Alta_Cliente", nombre, apellido, dni, mail, telefono, calle, nro_calle, piso, depto, localidad, codPostal, fechaNacimiento, username);
            return retorno;
        }

        public int modificarCliente( int dniViejo, string nombre, string apellido, int dni, string mail,
            int telefono, string calle, int numeroCalle, int piso, string depto, string localidad,
            string codPostal, DateTime fechaNacimiento)
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Modificar_Cliente", dniViejo, nombre, apellido, dni, mail, telefono, calle, numeroCalle, piso, depto, localidad, codPostal, fechaNacimiento);
            return retorno;
        }

        public List<DetallesClientes> getClientes()
        {
            return parseClientes(DBAdapter.retrieveDataTable("Get_Clientes"));
        }

        public DetallesClientes getCliente(int ID)
        {
            return parse(DBAdapter.retrieveDataTable("Get_Cliente", ID).Rows[0]);
        }

        public DetallesClientes getClienteByUserId(int uID)
        {
            var rows = DBAdapter.retrieveDataTable("obtenerClientePorCodigoUsuario", uID);
            if (rows.Rows.Count > 0)
            {
                return parse(rows.Rows[0]);
            }
            else
            {
                return null;
            }
            
        }

        private List<DetallesClientes> parseClientes(DataTable dataTable)
        {
            return dataTable.AsEnumerable().Select(dr => parse(dr)).ToList();
        }

        public List<DetallesClientes> filtrarClientes(string nombre, string apellido, int dni, string email)
        {
            var retorno = parseClientes(DBAdapter.retrieveDataTable("Filtrar_Usuarios_Cliente", nombre, apellido, dni, email));
            return retorno;
        }

        public DataTable filtrarClientesPaginado(int dni, int pagina)
        {
            var retorno = DBAdapter.retrieveDataTable("Historial_Cliente_Compras_Y_Ofertas_Paginado", dni, pagina);
            return retorno;
        }

        public int getCantidadResultados(int dni)
        {
            return DBAdapter.executeProcedureWithReturnValue("Cantidad_Historial_Cliente_Compras_Y_Ofertas", dni);
        }

        public DetallesClientes parse(DataRow dr)
        {
            return new DetallesClientes(
                Convert.ToInt32(dr["Cod_Cliente"]),
                new UsuariosRepository().getUsuario( Convert.ToInt32(dr["Cod_Usuario"]) ),
                dr["Nombre"] as string,
                dr["Apellido"] as string,
                Convert.ToInt32(dr["DNI"]),
                dr["Mail"] as string,
                Convert.ToInt32(dr["Telefono"]),
                new DomicilioRepository().getDomicilio(Convert.ToInt32(dr["Cod_Domicilio"])),
                dr["Cod_Postal"] as string,
                Convert.ToDateTime(dr["Fecha_Nacimiento"]),
                Convert.ToDateTime(dr["Fecha_Creacion"]),
                (Boolean)dr["Estado_Cliente"]
                );
        }

   }

}

