using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace APIGateway.Controllers
{
    public class ApiHelper
    {
        private static readonly HttpClient _httpClient;

        static ApiHelper()
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

        public static async Task<string> GetAsync(string uri)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, uri);
                HttpResponseMessage response = await _httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"Error: {response.StatusCode}, Content: {errorContent}");
                }
            }
            catch (HttpRequestException e)
            {
                throw new Exception($"HttpRequestException: {e.Message}", e);
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception: {ex.Message}", ex);
            }
        }

    }
}