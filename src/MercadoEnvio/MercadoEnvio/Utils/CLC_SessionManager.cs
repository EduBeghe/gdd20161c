using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using MercadoEnvio.Domain;
using MercadoEnvio.UI;
using System.Windows.Forms;
using MercadoEnvio.Repositories;

namespace MercadoEnvio.Utils
{
    class CLC_SessionManager
    {
        private static Usuario _usuario;
        public static Usuario currentUser { get { if (_usuario == null) throw new NoSessionIsOpenException(); else  return _usuario; } set { _usuario = value; } }
        public static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GD1C2016"].ConnectionString;      
        
        public static int getDNI(){
            
            var cliente = new ClientesRepository().getClienteByUserId(currentUser.Cod_Usuario);
            if (cliente != null)
            {
                return cliente.DNI;
            }
            else
            {
                return 0;
            }
            
        }

        public static DateTime getFecha()
        {
            return DateTime.Parse(System.Configuration.ConfigurationManager.AppSettings["fechaSistema"]);
        }

        public static string getCUIT()
        {
            var empresa = new EmpresaRepository().getEmpresaPorCodigoUsuario(currentUser.Cod_Usuario);
            if (empresa != null)
            {
                return empresa.CUIT;
            }
            else
            {
                return "";
            }
            
        }

        public static void setCurrentUser(Usuario u) {
            currentUser = u;
        }

        public static void closeSession()
        {
            currentUser = null;
        }

    }
}
