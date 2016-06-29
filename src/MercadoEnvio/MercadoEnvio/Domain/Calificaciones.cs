using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
    class Calificaciones
    {
        int Cod_Calificacion { get; set; }
        int Cantidad_Estrella { get; set; }
        int Peso { get; set; }
        string Descripcion { get; set; }

        public Calificaciones(int Cod_Calificacion, int Cantidad_Estrella, int Peso, string descripcion )
        {
            this.Cod_Calificacion = Cod_Calificacion;
            this.Cantidad_Estrella = Cantidad_Estrella;
            this.Peso = Peso;
            this.Descripcion = descripcion;
        }
    }
}
