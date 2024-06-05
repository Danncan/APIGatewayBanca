using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
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
        /*
        [HttpGet]
        [Route("api/Pagos/actualizarEstado/{codPago}/{serviceName}")]
        public bool actualizarEstado(string codPago,string serviceName)
        {

            return temMidleware.actualizarEstado(codPago, serviceName);
        }*/


        [HttpGet]
        [Route("api/Pagos/actualizarEstado2/{codPago}/{serviceName}")]
        public async Task<IHttpActionResult> actualizarEstado2(string codPago, string serviceName)
        {
            switch (serviceName)
            {
                case "Pago Almacenamiento en la Nube":
                    var gatewayPAN = "https://172.16.7.10:5019/api/ServicioPAN/actualizarEstadoPAN/"+codPago;
                    string responseContentPAN = await ApiHelper.GetAsync(gatewayPAN);
                    return Ok(responseContentPAN); // Devolver la respuesta como está
                case "Pago de Colegiaturas":
                    var gatewayPCA = "https://172.16.7.10:5022/api/ServicioPCA/actualizarEstado/"+codPago;
                    string responseContentPCA = await ApiHelper.GetAsync(gatewayPCA);
                    return Ok(responseContentPCA);
                case "Pago Planes":
                    var gatewayPTO = "https://172.16.7.10:5005/api/ServicioPTO/actualizarEstado/" + codPago;
                    string responseContentPTO = await ApiHelper.GetAsync(gatewayPTO);
                    return Ok(responseContentPTO);
                case "Recarga de Juegos":
                    var gatewayPRJ = "https://172.16.7.10:5011/api/ServicioPRJ/actualizarEstado/" + codPago;
                    string responseContentPRJ = await ApiHelper.GetAsync(gatewayPRJ);
                    return Ok(responseContentPRJ);
                case "Suscripcion de Musica":
                    var gatewayPSM = "http://172.16.7.10:5013/api/PSM/actualizarEstadoPSM/" + codPago;
                    string responseContentPSM = await ApiHelper.GetAsync(gatewayPSM);
                    return Ok(responseContentPSM);
                case "Awita":
                    var gatewayPMA = "https://172.16.7.10:5012/api/pma/actualizarEstadoPMA?codPago=" + codPago;
                    string responseContentPMA = await ApiHelper.GetAsync(gatewayPMA);
                    return Ok(responseContentPMA);
                case "MetroQuito":
                    var gatewayMQU = "https://172.16.7.10:5018/api/MandarDatosDTO/actualizar/" + codPago;
                    string responseContentMQU = await ApiHelper.GetAsync(gatewayMQU);
                    return Ok(responseContentMQU);
                case "Pago de Agua Potable":

                    var gatewayPSA = "https://172.16.7.10:5009/api/ServicioPSA/actualizarEstado/" + codPago;
                    string responseContentPSA = await ApiHelper.GetAsync(gatewayPSA);
                    return Ok(responseContentPSA);
                case "Xbox Game Pass":
                    var gatewayPXG = "https://172.16.7.10:5023/api/ServicioPXG/actualizarEstadoPXG/" + codPago;
                    string responseContentPXG = await ApiHelper.GetAsync(gatewayPXG);
                    return Ok(responseContentPXG);
                case "Pago de Impuesto Verde":
                    var gatewayPIV = "https://172.16.7.10:5008/api/ServicioPIV/actualizarEstado/"+ codPago;
                    string responseContentPIV = await ApiHelper.GetAsync(gatewayPIV);
                    return Ok(responseContentPIV);
                case "Servicio Internet":
                    var gatewayPPI = "https://172.16.7.10:5014/api/ServicioPIT/actualizarEstado/"+ codPago;
                    string responseContentPPI = await ApiHelper.GetAsync(gatewayPPI);
                    return Ok(responseContentPPI);
                case "Pago de Multas CNE":
                    var gatewayPMC = "https://172.16.7.10:5002/api/ServicioPMC/actualizarEstado/"+codPago;
                    string responseContentPMC = await ApiHelper.GetAsync(gatewayPMC);
                    return Ok(responseContentPMC);
                case "Servicio Electrico ACDC":
                    var gatewayPSE = "https://172.16.7.10:5021/api/ServicioPEO/actualizarEstadoPEO/" + codPago;
                    string responseContentPSE = await ApiHelper.GetAsync(gatewayPSE);
                    return Ok(responseContentPSE);
                case "Pago de Matricula de Autos":
                    var gatewayPIA = "https://172.16.7.10:5024/api/ServicioPIA/actualizarEstado/" + codPago;
                    string responseContentPIA = await ApiHelper.GetAsync(gatewayPIA);
                    return Ok(responseContentPIA);
                case "Pago Reserva de Hospedaje":
                    var gatewayPRH = "https://172.16.7.10:5017/api/ServicioPAH/actualizarEstadoPAH/" + codPago;
                    string responseContentPRH = await ApiHelper.GetAsync(gatewayPRH);
                    return Ok(responseContentPRH);
                    //audiolibros-ma
                case "Suscripcion AudioLibros":
                    var gatewayPAL = "https://172.16.7.10:5015/api/PAL/actualizarEstadoPAL/"+codPago;
                    string responseContentPAL = await ApiHelper.GetAsync(gatewayPAL);
                    return Ok(responseContentPAL);
                case "Suscripcion Max":
                    var gatewayPMX = "https://172.16.7.10:5016/api/PMX/actualizarEstadoPMX/"+codPago;
                    string responseContentPMX = await ApiHelper.GetAsync(gatewayPMX);
                    return Ok(responseContentPMX);
                case "Pago de Multas de Transito":
                    var gatewayPMT = "https://172.16.7.10:5003/api/ServicioPMT/actualizarEstado/"+codPago;
                    string responseContentPMT = await ApiHelper.GetAsync(gatewayPMT);
                    return Ok(responseContentPMT);
                case "Pago de Transportes":
                    var gatewayPTT = "https://172.16.7.10:5020/api/ServicioPDT/actualizarEstadoPDT/"+codPago;
                    string responseContentPTT = await ApiHelper.GetAsync(gatewayPTT);
                    return Ok(responseContentPTT);
                case "Pago de Servicio de Courier":
                    var gatewayPSC = "https://172.16.7.10:5010/api/ServicioPSC/actualizarEstadoPSC/"+codPago;
                    string responseContentPSC = await ApiHelper.GetAsync(gatewayPSC);
                    return Ok(responseContentPSC);
                case "Pago Brocker de Seguros":
                    var gatewayPBS = "https://172.16.7.10:5001/api/ServicioPDS/actualizarEstadoPDS/"+codPago;   
                    string responseContentPBS = await ApiHelper.GetAsync(gatewayPBS);
                    return Ok(responseContentPBS);

                default:
                    return NotFound();
            }
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
