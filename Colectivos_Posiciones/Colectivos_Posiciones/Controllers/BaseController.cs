using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colectivos_Posiciones.Controllers
{
    public class BaseController : Controller
    {
        private String baseURL = "https://apitransporte.buenosaires.gob.ar/colectivos/";      

        internal IRestResponse TraerDatos(String client_secret, String client_id)
        {
            String url = baseURL + "vehiclePositionsSimple?client_secret=" + client_secret + "&client_id=" + client_id;
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", "BIGipServerPool_apitransporte-BSAS-prd=2936017930.39455.0000; BIGipServerPool_apitransporte-prd=rd1o00000000000000000000ffff0a0a0560o8090");
            IRestResponse response = client.Execute(request);
            return response;
        }
    }
}
