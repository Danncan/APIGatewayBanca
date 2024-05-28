using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Middleware
{
    internal class ApiGateway
    {
        private HttpClient _httpClient;
        private string _baseUri;

        public ApiGateway(string baseUri)
        {
            _httpClient = new HttpClient();
            _baseUri = baseUri; // Base URI para el servicio
        }

        public async Task<bool> actualizarEstado(string codPago)
        {
            // Construye la URI completa utilizando el código de pago
            string uri = $"{_baseUri}+{codPago}";

            try
            {
                // Realiza la petición GET
                HttpResponseMessage response = await _httpClient.GetAsync(uri);

                // Asegúrate de que la respuesta es exitosa
                if (response.IsSuccessStatusCode)
                {
                    // Leer el contenido de la respuesta como un string y convertirlo a boolean
                    string responseContent = await response.Content.ReadAsStringAsync();
                    return bool.Parse(responseContent); // Asume que el servidor devuelve "true" o "false"
                }
                else
                {
                    // Manejo de respuesta no exitosa
                    Console.WriteLine($"Error: {response.StatusCode}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine($"Exception: {ex.Message}");
                return false;
            }
        }
    }
}

