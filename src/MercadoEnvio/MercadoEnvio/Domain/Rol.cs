
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class Rol
    {
        public int Cod_Rol { get; set; }
        public string Nombre { get; set; }
        public bool Estado_Rol { get; set; }
        public List<Funcionalidades> funcionalidad { get; set; }

        public Rol( int Cod_Rol, string Nombre, bool Estado_Rol, List<Funcionalidades> funcionalidad )
        {
            this.Cod_Rol = Cod_Rol;
            this.Nombre = Nombre;
            this.Estado_Rol = Estado_Rol;
            this.funcionalidad = funcionalidad;
        }

        public static Rol Copy(Rol r)
        {
            return new Rol(r.Cod_Rol, r.Nombre, r.Estado_Rol, r.funcionalidad);
        }
    }
}
