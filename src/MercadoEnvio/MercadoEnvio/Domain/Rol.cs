
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class Rol
    {
        int Cod_Rol { get; set; }
        string Nombre { get; set; }
        bool Estado_Rol { get; set; }
        List<Funcionalidades> funcionalidad { get; set; }

        public Rol( int Cod_Rol, string Nombre, bool Estado_Rol, Funcionalidades funcionalidad )
        {
            this.Cod_Rol = Cod_Rol;
            this.Nombre = Nombre;
            this.Estado_Rol = Estado_Rol;
            this.funcionalidad = funcionalidad;
        } 
    }
}
