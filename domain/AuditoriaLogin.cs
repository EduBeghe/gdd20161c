
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class AuditoriaLogin
    {
        int codigo { get; set; }
        Usuario usuario { get; set; }
        DateTime fecha { get; set; }
        bool estado { get; set; }
        int numeroIntento { get; set; }

        public AuditoriaLogin( int codigo, Usuario usuario, DateTime fecha, bool estado, int numeroIntento )
        {
            this.codigo = codigo;
            this.usuario = usuario;
            this.fecha = fecha;
            this.estado = estado;
            this.numeroIntento = numeroIntento;
        } 
    }
}
