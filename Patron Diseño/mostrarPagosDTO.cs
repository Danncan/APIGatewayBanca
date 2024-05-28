using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;


namespace Patron_Diseño
{
    public class mostrarPagosDTO
    {
        public mostrarPagosDTO() { }
        public mostrarPagosDTO(string codPago, decimal monto)
        {
            this.codPago = codPago;
            this.monto = monto;
        }
        public string codPago { get; set; }
        public decimal monto { get; set; }

        public mostrarPagosDTO(string tx)
        {
            JObject JObjectPagos = JObject.Parse(tx);
            codPago = (string)JObjectPagos["codPago"];
            monto = (decimal)JObjectPagos["monto"];
        }
        
    }
}
