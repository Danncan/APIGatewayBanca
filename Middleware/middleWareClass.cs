    using Newtonsoft.Json;
using Patron_Diseño;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Middleware
{
    public class middleWareClass
    {
        public List<mostrarServiciosDTO> mostrarServicios()
        {
            List<mostrarServiciosDTO> lstServicios = new List<mostrarServiciosDTO>();

            #region Almacenamiento en la Nube
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            string uriPAN = String.Format("https://172.16.7.10:5019/api/ServicioPAN/mostrarServicios");
            WebClient clientPAN = new WebClient();
            string respuestaPAN = clientPAN.DownloadString(new Uri(uriPAN));
            mostrarServiciosDTO datosPAN= JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPAN);
            lstServicios.Add(datosPAN);
            #endregion

            #region Planes de Telefono PTO
            string uriPTO = String.Format("https://172.16.7.10:5005/api/ServicioPTO/mostrarServicios");
            WebClient clientPTO = new WebClient();
            string respuestaPTO = clientPTO.DownloadString(new Uri(uriPTO));
            mostrarServiciosDTO datosPTO = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPTO);
            lstServicios.Add(datosPTO);
            #endregion

            #region Pagos Colegiaturas PCA
            string uriPCA = String.Format("http://172.16.0.183:5022/api/ServicioPCA");
            WebClient clientPCA = new WebClient();
            string respuestaPCA = clientPCA.DownloadString(new Uri(uriPCA));
            mostrarServiciosDTO datosPCA = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPCA);
            lstServicios.Add(datosPCA);
            #endregion

            #region Recarga de Juegos PRJ
            string uriPRJ = String.Format("http://172.16.7.10:5011/api/ServicioPRJ/mostrarServicioPRJ");
            WebClient clientPRJ = new WebClient();
            string respuestaPRJ = clientPRJ.DownloadString(new Uri(uriPRJ));
            mostrarServiciosDTO datosPRJ = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPRJ);
            lstServicios.Add(datosPRJ);
            #endregion


            return lstServicios;

        }

        public List<mostrarPagosDTO> mostrarPagos(string ci,string serviceName)
        {
            List<mostrarPagosDTO> lstPagos = new List<mostrarPagosDTO>();

            switch (serviceName)
            {
                case "Pago de Colegiaturas":
                    string uriPCA = String.Format("http://172.16.0.183:5022/api/ServicioPCA/mostrarPagos/" + ci);
                    WebClient clientPCA = new WebClient();
                    string respuestaPCA = clientPCA.DownloadString(new Uri(uriPCA));
                    List<mostrarPagosDTO> datosPCA = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPCA);
                    lstPagos.AddRange(datosPCA);
                    break;

                case "Pago Almacenamiento en la Nube":
                    string uriPAN = String.Format("https://172.16.7.10:5019/api/ServicioPAN/mostrarPagos/" + ci);
                    WebClient clientPAN = new WebClient();
                    string respuestaPAN = clientPAN.DownloadString(new Uri(uriPAN));
                    List<mostrarPagosDTO> datosPAN = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPAN);
                    lstPagos.AddRange(datosPAN);
                    break;
                case "Pago Planes":
                    string uriPTO = String.Format("https://172.16.7.10:5005/api/ServicioPTO/mostrarPagos/"+ci);
                    WebClient clientPTO = new WebClient();
                    string respuestaPTO = clientPTO.DownloadString(new Uri(uriPTO));
                    List<mostrarPagosDTO> datosPTO = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPTO);
                    lstPagos.AddRange(datosPTO);
                    break;
                

                default:
                    break;
            }
                   
            return lstPagos;

        }

        public async Task<bool> ActualizarEstado(string codPago, string serviceName)
        {
            switch (serviceName)
            {
                case "Pago de Colegiaturas":
                    var gatewayPCA = new ApiGateway("http://172.16.0.183:5022/api/ServicioPCA");
                    bool resultadoPCA = await gatewayPCA.actualizarEstado(codPago);
                    return resultadoPCA;

                case "Pago Almacenamiento en la Nube":
                    var gatewayPAN = new ApiGateway("https://172.16.7.10:5019/api/ServicioPAN/actualizarEstadoPAN/");
                    bool resultadoPAN = await gatewayPAN.actualizarEstado(codPago);
                    return resultadoPAN;
                
                case "Pago Planes":
                    var gatewayPTO = new ApiGateway("https://172.16.7.10:5005/api/ServicioPTO/actualizarEstado/");
                    bool resultadoPTO = await gatewayPTO.actualizarEstado(codPago);
                    return resultadoPTO;



                default:
                    break;
            }



            // Ejemplo de cómo instanciar y usar el ApiGateway
            var gateway = new ApiGateway("http://172.16.0.183:5022/api/ServicioPCA");
            bool resultado = await gateway.actualizarEstado(codPago);
            return resultado;
            
            //gateway = new ApiGateway("http://");
        }


    }
}
