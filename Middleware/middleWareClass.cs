using Middleware.Patron_Diseño;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Patron_Diseño;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

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
            string uriPCA = String.Format("https://172.16.7.10:5022/api/ServicioPCA");
            WebClient clientPCA = new WebClient();
            string respuestaPCA = clientPCA.DownloadString(new Uri(uriPCA));
            mostrarServiciosDTO datosPCA = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPCA);
            lstServicios.Add(datosPCA);
            #endregion


            #region Recarga de Juegos PRJ
            string uriPRJ = String.Format("https://172.16.7.10:5011/api/ServicioPRJ/mostrarServicioPRJ");
            WebClient clientPRJ = new WebClient();
            string respuestaPRJ = clientPRJ.DownloadString(new Uri(uriPRJ));
            mostrarServiciosDTO datosPRJ = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPRJ);
            lstServicios.Add(datosPRJ);
            #endregion

            #region Suscripcion Musica PSM 
            string uriPSM = String.Format("http://172.16.7.10:5013/api/PSM/mostrarServiciosPSM");
            WebClient clientPSM = new WebClient();
            string respuestaPSM = clientPSM.DownloadString(new Uri(uriPSM));
            mostrarServiciosDTO datosPSM = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPSM);
            lstServicios.Add(datosPSM);
            #endregion

            #region Membresias de Agua PMA
            string uriPMA = String.Format("https://172.16.7.10:5012/api/pma/mostrarServiciosPMA");
            WebClient clientPMA = new WebClient();
            string respuestaPMA = clientPMA.DownloadString(new Uri(uriPMA));
            mostrarServiciosDTO datosPMA = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPMA);
            lstServicios.Add(datosPMA);
            #endregion

            #region Metro de Quito MQU
            string uriMQU = String.Format("https://172.16.7.10:5018/api/MandarDatosDTO/descripcion");
            WebClient clientMQU = new WebClient();
            string respuestaMQU = clientMQU.DownloadString(new Uri(uriMQU));
            mostrarServiciosDTO datosMQU = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaMQU);
            lstServicios.Add(datosMQU);
            #endregion

            #region Pago Agua PSA
            string uriPSA = String.Format("https://172.16.7.10:5009/api/ServicioPSA/mostrarServicios");
            WebClient clientPSA = new WebClient();
            string respuestaPSA = clientPSA.DownloadString(new Uri(uriPSA));
            mostrarServiciosDTO datosPSA = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPSA);
            lstServicios.Add(datosPSA);
            #endregion

            #region Xbox Game Pass PXG
            string uriPXG = String.Format("https://172.16.7.10:5023/api/ServicioPXG/mostrarServiciosPXG");
            WebClient clientPXG = new WebClient();
            string respuestaPXG = clientPXG.DownloadString(new Uri(uriPXG));
            mostrarServiciosDTO datosPXG = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPXG);
            lstServicios.Add(datosPXG);
            #endregion

            #region Impuesto Verde PIV
            string uriPIV = String.Format("https://172.16.7.10:5008/api/ServicioPIV/mostrarServicios");
            WebClient clientPIV = new WebClient();
            string respuestaPIV = clientPIV.DownloadString(new Uri(uriPIV));
            mostrarServiciosDTO datosPIV = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPIV);
            lstServicios.Add(datosPIV);
            #endregion
            //Taaa

            #region Pago Brocker de Seguros PDS
            string uriPDS = String.Format("https://172.16.7.10:5001/api/ServicioPDS/mostrarServicios");
            WebClient clientPDS = new WebClient();
            string respuestaPDS = clientPDS.DownloadString(new Uri(uriPDS));
            mostrarServiciosDTO datosPDS = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPDS);
            lstServicios.Add(datosPDS);
            #endregion

            #region Pago de Multas de Transito PMT
            string uriPMT = String.Format("https://172.16.7.10:5003/api/ServicioPMT/mostrarServicios");
            WebClient clientPMT = new WebClient();
            string respuestaPMT = clientPMT.DownloadString(new Uri(uriPMT));
            mostrarServiciosDTO datosPMT = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPMT);
            lstServicios.Add(datosPMT);
            #endregion


            #region Suscripcion AudioLibros PAL
            string uriPAL = String.Format("https://172.16.7.10:5015/api/PAL/mostrarServiciosPAL");
            WebClient clientPAL = new WebClient();
            string respuestaPAL = clientPAL.DownloadString(new Uri(uriPAL));
            mostrarServiciosDTO datosPAL = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPAL);
            lstServicios.Add(datosPAL);
            #endregion

            #region Planes de Internet PIT
            string uriPIT = String.Format("https://172.16.7.10:5014/api/ServicioPIT/mostrarServicioPIT");
            WebClient clientPIT = new WebClient();
            string respuestaPIT = clientPIT.DownloadString(new Uri(uriPIT));
            mostrarServiciosDTO datosPIT = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPIT);
            lstServicios.Add(datosPIT);

            #endregion
            
            #region Pago de Multas CNE PMC
            string uriPMC = String.Format("https://172.16.7.10:5002/api/ServicioPMC/mostrarServicio");
            WebClient clientPMC = new WebClient();
            string respuestaPMC = clientPMC.DownloadString(new Uri(uriPMC));
            mostrarServiciosDTO datosPMC = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPMC);
            lstServicios.Add(datosPMC);
            #endregion

            #region Servicio Electrico ACDC PEO
            string uriPEO = String.Format("https://172.16.7.10:5021/api/ServicioPEO/mostrarServicios");
            WebClient clientPEO = new WebClient();
            string respuestaPEO = clientPEO.DownloadString(new Uri(uriPEO));
            mostrarServiciosDTO datosPEO = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPEO);
            lstServicios.Add(datosPEO);
            #endregion

            #region Pago de Matricula de Autos PIA
            string uriPIA = String.Format("https://172.16.7.10:5024/api/ServicioPIA/mostrarServicios");
            WebClient clientPIA = new WebClient();
            string respuestaPIA = clientPIA.DownloadString(new Uri(uriPIA));
            mostrarServiciosDTO datosPIA = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPIA);
            lstServicios.Add(datosPIA);
            #endregion

            #region Reserva de Hospedajes PAH
            string uriPAH = String.Format("https://172.16.7.10:5017/api/ServicioPAH/mostrarServicios");
            WebClient clientPAH = new WebClient();
            string respuestaPAH = clientPAH.DownloadString(new Uri(uriPAH));
            mostrarServiciosDTO datosPAH = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPAH);
            lstServicios.Add(datosPAH);
            #endregion

            #region Suscripcion Max PMX
            string uriPMX = String.Format("https://172.16.7.10:5016/api/PMX/mostrarServiciosPMX");
            WebClient clientPMX = new WebClient();
            string respuestaPMX = clientPMX.DownloadString(new Uri(uriPMX));
            mostrarServiciosDTO datosPMX = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPMX);
            lstServicios.Add(datosPMX);
            #endregion

            #region Pago de Transportes PDT
            string uriPDT = String.Format("https://172.16.7.10:5020/api/ServicioPDT/mostrarServicios");
            WebClient clientPDT = new WebClient();
            string respuestaPDT = clientPDT.DownloadString(new Uri(uriPDT));
            mostrarServiciosDTO datosPDT = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPDT);
            lstServicios.Add(datosPDT);
            #endregion

            #region Pago de Servicio de Courier PSC
            string uriPSC = String.Format("https://172.16.7.10:5010/api/ServicioPSC/mostrarServicioPSC");
            WebClient clientPSC = new WebClient();
            string respuestaPSC = clientPSC.DownloadString(new Uri(uriPSC));
            mostrarServiciosDTO datosPSC = JsonConvert.DeserializeObject<mostrarServiciosDTO>(respuestaPSC);
            lstServicios.Add(datosPSC);
            #endregion


            return lstServicios;

        }

        public List<mostrarPagosDTO> mostrarPagos(string ci,string serviceName)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            List<mostrarPagosDTO> lstPagos = new List<mostrarPagosDTO>();

            switch (serviceName)
            {
                case "Pago de Colegiaturas":
                    string uriPCA = String.Format("https://172.16.7.10:5022/api/ServicioPCA/mostrarPagos/" + ci);
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
                case "Recarga de Juegos":
                    string uriPRJ = String.Format("https://172.16.7.10:5011/api/ServicioPRJ/mostrarPagos/"+ci);
                    WebClient clientPRJ = new WebClient();
                    string respuestaPRJ = clientPRJ.DownloadString(new Uri(uriPRJ));
                    List<mostrarPagosDTO> datosPRJ = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPRJ);
                    lstPagos.AddRange(datosPRJ);
                    break;
                case "Suscripcion de Musica":
                    string uriPSM = String.Format("http://172.16.7.10:5013/api/PSM/mostrarPagosPSM/"+ci);
                    WebClient clientPSM = new WebClient();
                    string respuestaPSM = clientPSM.DownloadString(new Uri(uriPSM));
                    List<mostrarPagosDTO> datosPSM = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPSM);
                    lstPagos.AddRange(datosPSM);
                    break;
                case "Awita":
                    string uriPMA = String.Format("https://172.16.7.10:5012/api/pma/mostrarPagosPMA?cedula=" + ci);
                    WebClient clientPMA = new WebClient();
                    string respuestaPMA = clientPMA.DownloadString(new Uri(uriPMA));
                    List<mostrarPagosDTO> datosPMA = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPMA);
                    lstPagos.AddRange(datosPMA);
                    break;
                case "MetroQuito":
                    string uriMQU = String.Format("https://172.16.7.10:5018/api/MandarDatosDTO/" + ci);
                    WebClient clientMQU = new WebClient();
                    string respuestaMQU = clientMQU.DownloadString(new Uri(uriMQU));
                    List<mostrarPagosDTO> datosMQU = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaMQU);
                    lstPagos.AddRange(datosMQU);
                    break;
                case "Pago de Agua Potable":
                    string uriPSA = String.Format("https://172.16.7.10:5009/api/ServicioPSA/mostrarPagos/" + ci);
                    WebClient clientPSA = new WebClient();
                    string respuestaPSA = clientPSA.DownloadString(new Uri(uriPSA));
                    List<mostrarPagosDTO> datosPSA = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPSA);
                    lstPagos.AddRange(datosPSA);
                    break;
                case "Xbox Game Pass":
                    string uriPXG = String.Format("https://172.16.7.10:5023/api/ServicioPXG/mostrarPagosPXG/" + ci);
                    WebClient clientPXG = new WebClient();
                    string respuestaPXG = clientPXG.DownloadString(new Uri(uriPXG));
                    List<mostrarPagosDTO> datosPXG = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPXG);
                    lstPagos.AddRange(datosPXG);
                    break;
                case "Pago de Impuesto Verde":
                    string uriPIV = String.Format("https://172.16.7.10:5008/api/ServicioPIV/mostrarPagos/" + ci);
                    WebClient clientPIV = new WebClient();
                    string respuestaPIV = clientPIV.DownloadString(new Uri(uriPIV));
                    List<mostrarPagosDTO> datosPIV = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPIV);
                    lstPagos.AddRange(datosPIV);
                    break;
                case "Pago Brocker de Seguros":
                    string uriPDS = String.Format("https://172.16.7.10:5001/api/ServicioPDS/mostrarPagos/" + ci);
                    WebClient clientPDS = new WebClient();
                    string respuestaPDS = clientPDS.DownloadString(new Uri(uriPDS));
                    List<mostrarPagosDTO> datosPDS = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPDS);
                    lstPagos.AddRange(datosPDS);
                    break;

                case "Pago de Multas de Transito":
                    string uriPMT = String.Format("https://172.16.7.10:5003/api/ServicioPMT/MostrarPagosPMT/" + ci);
                    WebClient clientPMT = new WebClient();
                    string respuestaPMT = clientPMT.DownloadString(new Uri(uriPMT));
                    List<mostrarPagosDTO> datosPMT = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPMT);
                    lstPagos.AddRange(datosPMT);
                    break;

                case "Suscripcion AudioLibros":
                    string uriPAL = String.Format("https://172.16.7.10:5015/api/PAL/mostrarPagosPAL/" + ci);
                    WebClient clientPAL = new WebClient();
                    string respuestaPAL = clientPAL.DownloadString(new Uri(uriPAL));
                    List<mostrarPagosDTO> datosPAL = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPAL);
                    lstPagos.AddRange(datosPAL);
                    break;
                case "Servicio Internet":
                    string uriPIT = String.Format("https://172.16.7.10:5014/api/ServicioPIT/mostrarPagos/"+ci);
                    WebClient clientPIT = new WebClient();
                    string respuestaPIT = clientPIT.DownloadString(new Uri(uriPIT));
                    List<mostrarPagosDTO> datosPIT = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPIT);
                    lstPagos.AddRange(datosPIT);
                    break;
                case "Pago de Multas CNE":
                    string uriPMC = String.Format("https://172.16.7.10:5002/api/ServicioPMC/mostrarPagos/"+ci);
                    WebClient clientPMC = new WebClient();
                    string respuestaPMC = clientPMC.DownloadString(new Uri(uriPMC));
                    List<mostrarPagosDTO> datosPMC = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPMC);
                    lstPagos.AddRange(datosPMC);
                    break;
                case "Servicio Electrico ACDC":
                    string uriPEO = String.Format("https://172.16.7.10:5021/api/ServicioPEO/mostrarPagos/" + ci);
                    WebClient clientPEO = new WebClient();
                    string respuestaPEO = clientPEO.DownloadString(new Uri(uriPEO));
                    List<mostrarPagosDTO> datosPEO = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPEO);
                    lstPagos.AddRange(datosPEO);
                    break;
                case "Pago de Matricula de Autos":
                    string uriPIA = String.Format("https://172.16.7.10:5024/api/ServicioPIA/mostrarPagos/" + ci);
                    WebClient clientPIA = new WebClient();
                    string respuestaPIA = clientPIA.DownloadString(new Uri(uriPIA));
                    List<mostrarPagosDTO> datosPIA = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPIA);
                    lstPagos.AddRange(datosPIA);
                    break;
                case "Pago Reserva de Hospedaje":
                    string uriPAH = String.Format("https://172.16.7.10:5017/api/ServicioPAH/mostrarPagos/"+ci);
                    WebClient clientPAH = new WebClient();
                    string respuestaPAH = clientPAH.DownloadString(new Uri(uriPAH));
                    List<mostrarPagosDTO> datosPAH = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPAH);
                    lstPagos.AddRange(datosPAH);
                    break;

                case "Suscripcion Max":
                    string uriPMX = String.Format("https://172.16.7.10:5016/api/PMX/mostrarPagosPMX/"+ci);
                    WebClient clientPMX = new WebClient();
                    string respuestaPMX = clientPMX.DownloadString(new Uri(uriPMX));
                    List<mostrarPagosDTO> datosPMX = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPMX);
                    lstPagos.AddRange(datosPMX);
                    break;
                case "Pago de Transportes":
                    string uriPDT = String.Format("https://172.16.7.10:5020/api/ServicioPDT/mostrarPagos/" + ci);
                    WebClient clientPDT = new WebClient();
                    string respuestaPDT = clientPDT.DownloadString(new Uri(uriPDT));
                    List<mostrarPagosDTO> datosPDT = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPDT);
                    lstPagos.AddRange(datosPDT);
                    break;
                case "Pago de Servicio de Courier":
                    string uriPSC = String.Format("https://172.16.7.10:5010/api/ServicioPSC/mostrarPagosPSC/" + ci);
                    WebClient clientPSC = new WebClient();
                    string respuestaPSC = clientPSC.DownloadString(new Uri(uriPSC));
                    List<mostrarPagosDTO> datosPSC = JsonConvert.DeserializeObject<List<mostrarPagosDTO>>(respuestaPSC);
                    lstPagos.AddRange(datosPSC);
                    break;
                default:
                    break;
            }
                   
            return lstPagos;

        }
        /*
        public async Task<bool> ActualizarEstado(string codPago, string serviceName)
        {
            switch (serviceName)
            {
                case "Pago de Colegiaturas":
                    var gatewayPCA = new ApiGateway("http://172.16.0.183:5022/api/ServicioPCA/");
                    bool resultadoPCA = await gatewayPCA.actualizarEstado(codPago);
                    return resultadoPCA;

                case "Pago Almacenamiento en la Nube":
                    
                    var aaa = new HttpClientService();
                    var aaaaaaa = aaa.GetAsync("https://172.16.7.10:5019/api/ServicioPAN/actualizarEstadoPAN/PAN23");
                    var gatewayPAN = new ApiGateway("https://172.16.7.10:5019/api/ServicioPAN/actualizarEstadoPAN/");

                    string a = "https://172.16.7.10:5019/api/ServicioPAN/actualizarEstadoPAN/PAN23";
                    JObject JObjectPagos = JObject.Parse(a);
                    string codPagoPAN = JObjectPagos["codPago"].ToString();
                    bool aaaa = true;
                    
                    //bool resultadoPAN = await gatewayPAN.actualizarEstado(codPago);
                    /*
                    var prueba = new Prueba1();
                     var aaa =prueba.ActualizarEstadoPANAsync(codPago);
                    return true;
                
                case "Pago Planes":
                    var gatewayPTO = new ApiGateway("https://172.16.7.10:5005/api/ServicioPTO/actualizarEstado/");
                    bool resultadoPTO = await gatewayPTO.actualizarEstado(codPago);
                    return resultadoPTO;

                case "Recarga de Juegos":
                    var gatewayPRJ = new ApiGateway("http://172.16.7.10:5011/api/ServicioPRJ/actualizarEstado/");
                    bool resultadoPRJ = await gatewayPRJ.actualizarEstado(codPago);
                    return resultadoPRJ;
                case "Suscripcion de Musica":
                    var gatewayPSM = new ApiGateway("http://172.16.7.10:5013/api/PSM/actualizarEstadoPSM/");
                    bool resultadoPSM = await gatewayPSM.actualizarEstado(codPago);
                    return resultadoPSM;
                case "Awita":
                    //Enrutamiento a la API de PMA
                    var gatewayPMA = new ApiGateway("https://172.16.7.10:5012/api/pma/actualizarEstadoPMA/");
                    bool resultadoPMA = await gatewayPMA.actualizarEstado(codPago);
                    return resultadoPMA;
                case "MetroQuito":
                    var gatewayMQU = new ApiGateway("https://172.16.7.10:5018/api/MandarDatosDTO/actualizar/");
                    bool resultadosMQU = await gatewayMQU.actualizarEstado(codPago);
                    return resultadosMQU;

                case "Pago de Agua Potable":
                    var gatewayPSA = new ApiGateway("https://172.16.7.10:5009/api/ServicioPSA/actualizarEstado/");
                    bool resultadoPSA = await gatewayPSA.actualizarEstado(codPago);
                    return resultadoPSA;
                case "Xbox Game Pass":
                    var gatewayPXG = new ApiGateway("https://172.16.7.10:5023/api/actualizarEstadoPXG/");
                    bool resultadoPXG = await gatewayPXG.actualizarEstado(codPago);
                    return resultadoPXG;
                case "Pago de Impuesto Verde":
                    var gatewayPIV = new ApiGateway("https://172.16.7.10:5008/api/ServicioPIV/actualizarEstado/");
                    bool resultadoPIV = await gatewayPIV.actualizarEstado(codPago);
                    return resultadoPIV;

                default:
                    break;
            }


            return false;
        }*/


    }
}
