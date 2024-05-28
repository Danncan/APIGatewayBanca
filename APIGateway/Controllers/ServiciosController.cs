using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Logica;
using Patron_Diseño;

namespace APIGateway.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ServiciosController : ApiController
    {
        logicaMiddeware temMidleware = new logicaMiddeware();
        // GET: api/Servicios
        public List<mostrarServiciosDTO> Get()
        {
            return temMidleware.mostrarServicios();
        }

        // GET: api/Servicios/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet]
        [Route("api/Pagos/mostrarPagos/{ci}/{serviceName}")]
        public List<mostrarPagosDTO> mostrarPagos(string ci,string serviceName)
        {
            return temMidleware.mostrarPagos(ci, serviceName);
        }

        [HttpGet]
        [Route("api/Pagos/actualizarEstado/{codPago}/{serviceName}")]
        public bool actualizarEstado(string codPago,string serviceName)
        {
            return temMidleware.actualizarEstado(codPago, serviceName);
        }


        // POST: api/Servicios
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Servicios/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Servicios/5
        public void Delete(int id)
        {
        }
    }
}
