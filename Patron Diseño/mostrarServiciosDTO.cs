using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Patron_Diseño
{
    public class mostrarServiciosDTO
    {
        public mostrarServiciosDTO() { }
        public mostrarServiciosDTO(string nombre, string descripcion)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public mostrarServiciosDTO(string tx)
        {
            JObject JObjectServicios = JObject.Parse(tx);
            Nombre = (string)JObjectServicios["Nombre"];
            Descripcion= (string)JObjectServicios["Descripcion"];
        }

    }
}
