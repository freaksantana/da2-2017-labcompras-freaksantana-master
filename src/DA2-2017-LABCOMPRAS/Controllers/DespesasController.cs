using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DA2_2017_LABCOMPRAS.Controllers
{
    public class DespesasController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NovaDespesa()
        {
            ViewBag.Texto = "Bem-Vindo ao site das Despesas!";
            return View();
        }
    }
}
