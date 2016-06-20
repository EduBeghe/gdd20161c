using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DateTime;
using System.Threading.Tasks;

namespace MercadoEnvio.Domain
{
        
    public class DetalleEmpresa
    {
        public string Razon_Social { get; set; }
        public string Mail { get; set; }
        public int Telefono { get; set; }
        public Domicilio domicilio { get; set; }
        public string Cod_Postal { get; set; }
        public string Ciudad { get; set; }
        public string CUIT { get; set; }
        public bool Estado_Empresa { get; set; }
        public Rubros rubro { get; set; }
        public string username { get; set; }


        public DetalleEmpresa( 
            string Razon_Social,
            string Mail,
            int Telefono,
            Domicilio domicilio,
            string Cod_Postal,
            string Ciudad,
            string CUIT ,
            bool Estado_Empresa,
            string username
            )
        {
            this.Razon_Social = Razon_Social;
            this.Mail = Mail;
            this.Telefono = Telefono;
            this.domicilio = domicilio;
            this.Cod_Postal = Cod_Postal;
            this.Ciudad = Ciudad;
            this.CUIT = CUIT;
            this.Estado_Empresa = Estado_Empresa;
            this.username = username;
        }

    }
}
