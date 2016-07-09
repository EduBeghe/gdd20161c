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
        // rol seleccionado 

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

        public static bool esCliente()
        {
            Rol rol = currentUser.roles.Find(x => (x.Nombre == "Cliente"));
            return (rol != null);
        }

        public static bool esEmpresa()
        {
            Rol rol = currentUser.roles.Find(x => (x.Nombre == "Empresa"));
            return (rol != null);
        }

        public static bool esAdministrador()
        {
            Rol rol1 = currentUser.roles.Find(x => (x.Nombre == "Administrador"));
            Rol rol2 = currentUser.roles.Find(x => (x.Nombre == "Administrador General"));
            return (rol1 != null || rol2 != null );
        }


        public static DateTime getFecha()
        {
            var fecha = System.Configuration.ConfigurationManager.AppSettings["fechaSistema"];
            return DateTime.Parse( fecha );
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

        // Modificar parametro de ingreso para que se guarda el rol seleccionado
        public static void setCurrentUser(Usuario u) {
            currentUser = u;
            // rol seeleccionado = ingreso de rol seleccionado
        }

        public static void closeSession()
        {
            currentUser = null;
        }

    }
}
