using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class Publicacion
    {
        Estado estado { get; set; }
        DateTime fecha_inicio { get; set; }
        DateTime fecha_finalizacion { get; set; } 
        int codigo { get; set; }
        string descripcion { get; set; }
        int stock { get; set; }
        int precio { get; set; }        
        int costo { get; set; }
        Rubro rubro { get; set; }
        bool visible { get; set; }
        Usuario publicador { get; set; }
        Estado estado { get; set; }
        bool permite_preguntas { get; set; }

        public Publicacion( Estado estado, DateTime fecha_inicio, DateTime fecha_finalizacion, int codigo, string descripcion, int stock, int precio, int costo, Rubro rubro, bool visible, Usuario publicador, bool permite_preguntas  )
        {
            this.estado = estado;
            this.fecha_inicio = fecha_inicio;
            this.fecha_finalizacion = fecha_finalizacion; 
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;        
            this.costo = costo;
            this.rubro = rubro;
            this.visible = visible;
            this.publicador = publicador;
            this.estado = estado;
            this.permite_preguntas = permite_preguntas;            
        }

    }
}
