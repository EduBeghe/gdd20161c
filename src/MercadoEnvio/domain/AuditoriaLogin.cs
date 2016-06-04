
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class AuditoriaLogin
    {
        int Cod_Auditoria { get; set; }
        Usuario usuario { get; set; }
        DateTime Fecha { get; set; }
        bool Estado { get; set; }
        int Numero_De_Intento { get; set; }

        public AuditoriaLogin( int Cod_Auditoria, Usuario usuario, DateTime Fecha, bool Estado, int Numero_De_Intento )
        {
            this.Cod_Auditoria = Cod_Auditoria;
            this.usuario = usuario;
            this.Fecha = Fecha;
            this.Estado = Estado;
            this.Numero_De_Intento = Numero_De_Intento;
        } 
    }
}
