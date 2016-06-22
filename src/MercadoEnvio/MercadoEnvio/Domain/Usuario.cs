using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class Usuario
    {
        public int Cod_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string password { get; set; }
        public int codigo_rol { get; set; }
        public int Intentos_Login { get; set; }
        public int Reputacion { get; set; }
        public bool Estado_Usuario  { get; set; }

       public Usuario( int Cod_Usuario, string Nombre_Usuario, string password, int codigo_rol, 
            int intentosLogin, int reputacion, bool estadoUsuario )
        {
            this.Cod_Usuario = Cod_Usuario;
            this.Nombre_Usuario = Nombre_Usuario;
            this.password = password;
            this.codigo_rol = codigo_rol;
            this.Intentos_Login = Intentos_Login;
            this.Reputacion = reputacion;
            this.Estado_Usuario = Estado_Usuario;
        }

    }
}
