using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class DetalleEmpresa
    {
        public int Cod_Empresa { get; set; }
        public int Cod_Usuario { get; set; }
        public string Razon_Social { get; set; }
        public string Mail { get; set; }
        public int Telefono { get; set; }
        public Domicilio domicilio { get; set; }
        public string Cod_Postal { get; set; }
        public string Ciudad { get; set; }
        public string CUIT { get; set; }
        public bool Estado_Empresa { get; set; }
        public string rubro { get; set; }
        public string nombreContacto { get; set; }

        public DetalleEmpresa( 
            int Cod_Empresa,
            int Cod_Usuario,
            string Razon_Social,
            string Mail,
            int Telefono,
            Domicilio domicilio,
            string Cod_Postal,
            string Ciudad,
            string CUIT ,
            bool Estado_Empresa,
            string rubro,
            string nombreContacto
            )
        {
            this.Cod_Empresa = Cod_Empresa;
            this.Cod_Usuario = Cod_Usuario;
            this.Razon_Social = Razon_Social;
            this.Mail = Mail;
            this.Telefono = Telefono;
            this.domicilio = domicilio;
            this.Cod_Postal = Cod_Postal;
            this.Ciudad = Ciudad;
            this.CUIT = CUIT;
            this.Estado_Empresa = Estado_Empresa;
            this.rubro = rubro;
            this.nombreContacto = nombreContacto;
        }

    }
}
