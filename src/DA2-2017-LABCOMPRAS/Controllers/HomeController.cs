using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
    }
}
