﻿using Patron_Diseño;
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
                case "Pago de Colegiaturas":
                    mostrarPagosDTO pago4 = new mostrarPagosDTO("Pago de Colegiatura1" + ci, 100);
                    lstPagos.Add(pago4);
                    pago4 = new mostrarPagosDTO("Pago de Colegiatur2" + ci, 200);
                    lstPagos.Add(pago4);
                    pago4 = new mostrarPagosDTO("Pago de Colegiatur3" + ci, 300);
                    lstPagos.Add(pago4);
                    pago4 = new mostrarPagosDTO("Pago de Colegiatur4" + ci, 400);
                    lstPagos.Add(pago4);
                    break;
                case "Pago Almacenamiento en la Nube":
                    mostrarPagosDTO pago5 = new mostrarPagosDTO( "Pago Almacenamiento en la Nube1" + ci);
                    lstPagos.Add(pago5);
                    pago5 = new mostrarPagosDTO("Pago Almacenamiento en la Nube2" + ci, 200);
                    lstPagos.Add(pago5);
                    break;
                case "Pago Planes":
                    mostrarPagosDTO pago6 = new mostrarPagosDTO("Pago Planes1" + ci, 100);
                    lstPagos.Add(pago6);
                    pago6 = new mostrarPagosDTO("Pago Planes2" + ci, 200);
                    lstPagos.Add(pago6);
                    pago6 = new mostrarPagosDTO("Pago Planes3" + ci, 300);
                    lstPagos.Add(pago6);
                    pago6 = new mostrarPagosDTO("Pago Planes4" + ci, 400);
                    lstPagos.Add(pago6);
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

    }
}
