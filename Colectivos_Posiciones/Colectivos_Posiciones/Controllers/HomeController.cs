using Colectivos_Posiciones.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Colectivos_Posiciones.Controllers
{
    public class HomeController : BaseController
    {
        private String api_key_google_maps = "XXXXXX";
        private String client_secret_api_gcba= "XXXXXX";
        private String client_id_api_gcba = "XXXXXX";
        
        public ActionResult Index()
        {            
            ViewBag.API_KEY = api_key_google_maps; 
            return View();
        }

        [HttpGet]
        public ActionResult VerColectivos()
        {
            IRestResponse colectivos = TraerDatos(client_secret_api_gcba, client_id_api_gcba);
            return Json(colectivos.Content);
        }
    }
}
