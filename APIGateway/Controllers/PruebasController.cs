using Patron_Diseño;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace APIGateway.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PruebasController : ApiController
    {
        private static readonly HttpClient _httpClient;

        static PruebasController()
        {
            var handler = new HttpClientHandler
            {
                // Ignorar los errores de certificado SSL
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };

            _httpClient = new HttpClient(handler)
            {
                Timeout = TimeSpan.FromSeconds(30) // Configura el tiempo de espera
            };

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        [HttpGet]
        [Route("api/Pruebas/actualizarEstado")]
        public async Task<IHttpActionResult> ActualizarEstado()
        {
            string uri = "https://172.16.7.10:5019/api/ServicioPAN/actualizarEstadoPAN/";
            Console.WriteLine($"Constructed URI: {uri}");

            try
            {
                // Crear la solicitud HTTP
                var request = new HttpRequestMessage(HttpMethod.Get, uri);

                // Enviar la solicitud HTTP
                Console.WriteLine("Sending GET request...");
                HttpResponseMessage response = await _httpClient.SendAsync(request);
                Console.WriteLine("GET request sent.");

                // Asegúrate de que la respuesta es exitosa
                if (response.IsSuccessStatusCode)
                {
                    // Leer el contenido de la respuesta como un string
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Response Content: {responseContent}");
                    return Ok(responseContent); // Devolver la respuesta como está
                }
                else
                {
                    // Manejo de respuesta no exitosa
                    string errorContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}");
                    Console.WriteLine($"Error Content: {errorContent}");
                    return Content(response.StatusCode, errorContent);
                }
            }
            catch (HttpRequestException e)
            {
                // Manejo de excepciones específicas de solicitudes HTTP
                Console.WriteLine($"HttpRequestException: {e.Message}");
                return InternalServerError(e);
            }
            catch (Exception ex)
            {
                // Manejo de otras excepciones
                Console.WriteLine($"Exception: {ex.Message}");
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("api/Pruebas/mostrarPagos/{ci}/{serviceName}")]
        public List<mostrarPagosDTO> mostrarPagos(string ci, string serviceName)
        {
            List<mostrarPagosDTO> lstPagos = new List<mostrarPagosDTO>();
            switch (serviceName)
            {
                case "Servicio1":
                    mostrarPagosDTO pago1 = new mostrarPagosDTO("Pago1s1" + ci, 100);
                    lstPagos.Add(pago1);
                    pago1 = new mostrarPagosDTO("Pago2s1" + ci, 200);
                    lstPagos.Add(pago1);
                    pago1 = new mostrarPagosDTO("Pago3s1" + ci, 300);
                    lstPagos.Add(pago1);
                    pago1 = new mostrarPagosDTO("Pago4" + ci, 400);
                    lstPagos.Add(pago1);
                    break;
                case "Servicio2":
                    mostrarPagosDTO pago2 = new mostrarPagosDTO("Pago1s2" + ci, 100);
                    lstPagos.Add(pago2);
                    pago2 = new mostrarPagosDTO("Pago2s2" + ci, 200);
                    lstPagos.Add(pago2);
                    pago2 = new mostrarPagosDTO("Pago3s2" + ci, 300);
                    lstPagos.Add(pago2);
                    pago2 = new mostrarPagosDTO("Pago4s2" + ci, 400);
                    lstPagos.Add(pago2);
                    break;
                case "Servicio3":
                    mostrarPagosDTO pago3 = new mostrarPagosDTO("Pago1s3" + ci, 100);
                    lstPagos.Add(pago3);
                    pago3 = new mostrarPagosDTO("Pago2s3" + ci, 200);
                    lstPagos.Add(pago3);
                    pago3 = new mostrarPagosDTO("Pago3s3" + ci, 300);
                    lstPagos.Add(pago3);
                    pago3 = new mostrarPagosDTO("Pago4s3" + ci, 400);
                    lstPagos.Add(pago3);
                    break;
                default:
                    break;
            }

            return lstPagos;
        }

        [HttpGet]
        [Route("api/Pruebas/mostrarServicios")]
        // GET: api/Pruebas/5
        public List<mostrarServiciosDTO> mostrarServicios()
        {
            List<mostrarServiciosDTO> lstServicios = new List<mostrarServiciosDTO>();
            mostrarServiciosDTO servicio1 = new mostrarServiciosDTO("Servicio1", "Descripcion1");
            lstServicios.Add(servicio1);
            servicio1 = new mostrarServiciosDTO("Servicio2", "Descripcion2");
            lstServicios.Add(servicio1);
            servicio1 = new mostrarServiciosDTO("Servicio3", "Descripcion3");
            lstServicios.Add(servicio1);
            servicio1 = new mostrarServiciosDTO("Servicio4", "Descripcion4");
            lstServicios.Add(servicio1);
            return lstServicios;
        }

        [HttpGet]
        [Route("api/Pruebas/mostrarPagos")]
        // POST: api/Pruebas
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Pruebas/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Pruebas/5
        public void Delete(int id)
        {
        }
    }
}
