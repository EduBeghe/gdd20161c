using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MercadoEnvio.Utils;
using MercadoEnvio.Domain;

namespace MercadoEnvio.Repositories
{

    class UsuariosRepository
    {

        public int altaUsuario(string usuario, string pass, int codRol)
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("Alta_Usuario", usuario, new Encription().encryptToSHA256(pass), codRol);
            return retorno;
        }

        public void bajaUsuario(string nombreUsuario)
        {
            DBAdapter.executeProcedure("Baja_Usuario", nombreUsuario);
        }

        public void modificarUsuario(string nombreUsuario, string passwordVieja, string passwordNueva)
        {
            DBAdapter.executeProcedure("Modificar_Usuario", nombreUsuario, passwordVieja, passwordNueva);
        }

        public int validarLogin(string usuario, string pass)
        {
            var cantUsuarios = DBAdapter.executeProcedureWithReturnValue("Validar_Login", usuario, new Encription().encryptToSHA256(pass));
            return cantUsuarios;
        }

        public void iniciarSesion(string userName)
        {
            var usr = getUsuarioPorUsername(userName);
            if (usr != null) CLC_SessionManager.setCurrentUser(usr);
            else MessageBox.Show("Usuario es null");
        }

        public Usuario getUsuarioPorUsername(String username)
        {
            var table = DBAdapter.retrieveDataTable("Get_Usuario_Por_Username", username);
            if (table != null && table.Rows.Count > 0) return parse(table.Rows[0]);
            else return null;
        }

        public Usuario getUsuario(int userID )
        {
            return parse(DBAdapter.retrieveDataTable("Get_Usuario", userID).Rows[0]);
        }

        public int getUsuarioIDPorIdentificadores(int dni, string cuit)
        {
            var retorno = DBAdapter.executeProcedureWithReturnValue("ObtenerUsuario", dni, cuit);
            return retorno;
        }

        public void actualizarIntentosLogin(string userName, int cantidad)
        {
            DBAdapter.executeProcedure("ActualizarIntentos", userName, cantidad);
        }


        private Usuario parse(DataRow dr)
        {

            return new Usuario(
               Convert.ToInt32(dr["Cod_Usuario"]),

               dr["Nombre_Usuario"] as string,

               dr["contrasenia"] as string,

               new RolesRepository().getRol(Convert.ToInt32(dr["Cod_Rol"])),

               Convert.ToInt32(dr["Intentos_Login"]),

               Convert.ToInt32(dr["Reputacion"]),

               (Boolean)dr["Estado_Usuario"]
               );

        }
    }

}

