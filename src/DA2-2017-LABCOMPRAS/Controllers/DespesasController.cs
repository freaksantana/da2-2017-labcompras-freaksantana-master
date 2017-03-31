using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DA2_2017_LABCOMPRAS.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DA2_2017_LABCOMPRAS.Controllers
{
    public class DespesasController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
             ViewBag.Texto = "Bem-Vindo ao site das Despesas!";
            Models.Despesa outradespesa = new Models.Despesa("Conta da Luz", 5, 100, "EDP", false);
            return View(outradespesa);
        }

        [HttpGet]
        public IActionResult NovaDespesa()
        {
            ViewBag.Texto = "Bem-Vindo ao site das Despesas!";
            return View();
        }

        [HttpPost]
        public IActionResult NovaDespesa(Despesa obj)
        {
            if (ModelState.IsValid)
            {
                return View("DespesaConfirmada", obj);
            }
            else
                return View();
    
        }

      
        public IActionResult DespesaConfirmada()
        {
            ViewBag.Texto = "Confirme a sua despesa.";
            return View();
        }
    }
}
