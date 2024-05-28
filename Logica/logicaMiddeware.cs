using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Middleware;
using Patron_Diseño;

namespace Logica
{
    public class logicaMiddeware
    {
        middleWareClass temMidleware = new middleWareClass();
        
        public List<mostrarServiciosDTO> mostrarServicios()
        {
            return temMidleware.mostrarServicios();
        }

        public List<mostrarPagosDTO> mostrarPagos(string ci,string serviceName)
        {
            return temMidleware.mostrarPagos(ci, serviceName);
        }

        public bool actualizarEstado(string codPago, string serviceName)
        {
            return temMidleware.ActualizarEstado(codPago, serviceName).Result;
        }
    }
}
