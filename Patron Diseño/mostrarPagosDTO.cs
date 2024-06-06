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

        //Constructor para parsear el JSON
        public mostrarPagosDTO(string tx)
        {
            //Parsear el JSON
            JObject JObjectPagos = JObject.Parse(tx);
            //Obtener los valores de los atributos
            codPago = (string)JObjectPagos["codPago"];
            monto = (decimal)JObjectPagos["monto"];
        }
        
    }
}
