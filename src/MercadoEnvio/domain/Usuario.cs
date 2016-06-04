using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class Usuario
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public Rol rol { get; set; }
        public bool estadoUsuario  { get; set; }
        public int telefono { get; set; }
        public string mail { get; set; }      
        public Direccion direccion { get; set; }
        public int codigoPostal { get; set; }
        public int intentosLogin { get; set; }

        public Usuario( int id, string userName, string password, Rol rol, 
            int telefono, string mail, int codigo_postal, Direccion direccion, int intentosLogin
            bool estadoUsuario )
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.rol = rol;     
            this.telefono = telefono;
            this.mail = mail;
            this.codigo_postal = codigo_postal;
            this.direccion = direccion;
            this.intentosLogin = intentosLogin;
            this.estadoUsuario = estadoUsuario;
        }

    }
}
