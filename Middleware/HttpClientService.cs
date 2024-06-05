using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Net.Security;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading.Tasks;

    namespace Patron_Diseño
    {
        public class HttpClientService
        {
            private readonly HttpClient _httpClient;

            public HttpClientService()
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

            public async Task<string> GetAsync(string uri)
            {
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
                        return responseContent;
                    }
                    else
                    {
                        // Manejo de respuesta no exitosa
                        string errorContent = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Error: {response.StatusCode}");
                        Console.WriteLine($"Error Content: {errorContent}");
                        throw new HttpRequestException($"Error: {response.StatusCode}, Content: {errorContent}");
                    }
                }
                catch (HttpRequestException e)
                {
                    // Manejo de excepciones específicas de solicitudes HTTP
                    Console.WriteLine($"HttpRequestException: {e.Message}");
                    throw;
                }
                catch (Exception ex)
                {
                    // Manejo de otras excepciones
                    Console.WriteLine($"Exception: {ex.Message}");
                    throw;
                }
            }
        }
    }

}
