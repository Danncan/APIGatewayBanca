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
        //Constructor para parsear el JSON
        public mostrarServiciosDTO(string tx)
        {
            //Parsear el JSON
            JObject JObjectServicios = JObject.Parse(tx);
            //Obtener los valores de los atributos
            Nombre = (string)JObjectServicios["Nombre"];
            Descripcion= (string)JObjectServicios["Descripcion"];
        }

    }
}
