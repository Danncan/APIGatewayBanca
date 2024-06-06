using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace APIGateway.Controllers
{
    // Clase para realizar peticiones HTTP
    public class ApiHelper
    {
        // Cliente HTTP para realizar peticiones
        private static readonly HttpClient _httpClient;

        static ApiHelper()
        {
            // Configurar el cliente HTTP
            var handler = new HttpClientHandler
            {
                // Ignorar los errores de certificado SSL
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };

            // Crear el cliente HTTP
            _httpClient = new HttpClient(handler)
            {
                Timeout = TimeSpan.FromSeconds(30) // Configura el tiempo de espera
            };

            // Configurar el encabezado de aceptación
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        // Método para realizar una petición GET
        public static async Task<string> GetAsync(string uri)
        {
            try
            {
                // Crear la solicitud GET con la URI especificada
                var request = new HttpRequestMessage(HttpMethod.Get, uri);
                // Realizar la solicitud y esperar la respuesta del servidor
                HttpResponseMessage response = await _httpClient.SendAsync(request);
                // Verificar si la solicitud fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    // Leer el contenido de la respuesta y devulve
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    // Leer el contenido de la respuesta y lanzar una excepción
                    string errorContent = await response.Content.ReadAsStringAsync();
                    // Lanzar una excepción con el código de estado y el contenido del error
                    throw new HttpRequestException($"Error: {response.StatusCode}, Content: {errorContent}");
                }
            }
            // Capturar excepciones de solicitud HTTP
            catch (HttpRequestException e)
            {
                // Lanzar una excepción con el mensaje de error
                throw new Exception($"HttpRequestException: {e.Message}", e);
            }
            catch (Exception ex)
            {
                // Lanzar una excepción con el mensaje de error
                throw new Exception($"Exception: {ex.Message}", ex);
            }
        }

    }
}