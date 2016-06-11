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


        public int ValidarLogin( string usuario, string pass )
		{
			var cantUsuarios = DBAdapter.executeProcedureWithReturnValue("Validar_Login", usuario, new Encription().encryptToSHA256( pass ) );
            return cantUsuarios;
		}

        public void iniciarSesion(string userName) {
            CLC_SessionManager.currentUser = getUsuario( userName ) ;
            var usr = getUsuario(userName);
            if ( usr != null ) CLC_SessionManager.setCurrentUser( usr );
            else MessageBox.Show("usr es null");
        }

        public Usuario getUsuario( string username )
        {
            return parse(DBAdapter.retrieveDataTable("GetUsuario", username).Rows[0]);
        }

        private Usuario parse(DataRow dr)
        {

            return new Usuario(Convert.ToInt32(dr["Cod_Usuario"]),

               dr["Nombre_Usuario"] as string,

               dr["password"] as string,

               Convert.ToInt32(dr["Intentos_Login"]), 

               (Boolean) dr["Estado_Usuario"];

               );

        }



    }

