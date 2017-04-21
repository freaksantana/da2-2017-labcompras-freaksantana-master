using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using DA2_2017_LABCOMPRAS.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DA2_2017_LABCOMPRAS.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Entrada";
            ViewBag.Texto = "Bem-Vindo à Página do Index";
            return View();
        }

        public IActionResult Conceito()
        {
            ViewBag.Title = "Entrada da página Conceito";
            ViewBag.Texto = "Um Novo Conceito";
            return View();
        }

        public IActionResult Tempo()
        {
            HttpClient client = new HttpClient();
            string baseAddress = "http://api.apixu.com/";
            client.BaseAddress = new Uri(baseAddress);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new
            MediaTypeWithQualityHeaderValue("application/json"));
            string path = "v1/current.json?key=A_SUA_CHAVE&q=Albufeira";
            HttpResponseMessage response = client.GetAsync(path).Result;
            WeatherApiResponse wc = response.Content.ReadAsAsync<WeatherApiResponse>().Result;

            return View(wc);
        }
    }
}

