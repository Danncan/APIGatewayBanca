using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Middleware
{
    internal class ApiGateway
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUri;

        public ApiGateway(string baseUri)
        {
            var handler = new HttpClientHandler
            {
                // Ignorar los errores de certificado SSL (si es seguro hacerlo)
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };

            _httpClient = new HttpClient(handler)
            {
                Timeout = TimeSpan.FromSeconds(30) // Configura el tiempo de espera
            };
            _baseUri = baseUri; // Base URI para el servicio
        }

        public async Task<bool> actualizarEstado(string endpoint)
        {
            // Construye la URI completa utilizando el endpoint
            string uri = $"{_baseUri}{endpoint}";
            Console.WriteLine($"Constructed URI: {uri}");

            try
            {
                // Crear la solicitud HTTP
                var request = new HttpRequestMessage(HttpMethod.Get, uri);

                // Agregar encabezados si es necesario
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Enviar la solicitud HTTP
                Console.WriteLine("Sending GET request...");
                HttpResponseMessage response = await _httpClient.SendAsync(request);
                Console.WriteLine("GET request sent.");

                // Asegúrate de que la respuesta es exitosa
                if (response.IsSuccessStatusCode)
                {
                    // Leer el contenido de la respuesta como un string y convertirlo a boolean
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Response Content: {responseContent}");
                    return bool.Parse(responseContent); // Asume que el servidor devuelve "true" o "false"
                }
                else
                {
                    // Manejo de respuesta no exitosa
                    Console.WriteLine($"Error: {response.StatusCode}");
                    Console.WriteLine($"Error Content: {await response.Content.ReadAsStringAsync()}");
                    return false;
                }
            }
            catch (HttpRequestException e)
            {
                // Manejo de excepciones específicas de solicitudes HTTP
                Console.WriteLine($"HttpRequestException: {e.Message}");
                return false;
            }
            catch (Exception ex)
            {
                // Manejo de otras excepciones
                Console.WriteLine($"Exception: {ex.Message}");
                return false;
            }
        }
    }
}
