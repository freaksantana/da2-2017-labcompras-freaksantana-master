using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DA2_2017_LABCOMPRAS.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DA2_2017_LABCOMPRAS.Controllers
{
    public class ContaBancariaController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Texto = "Bem-Vindo ao site da Conta Bancária";
            return View();
        }

        [HttpGet]
        public IActionResult NovaContaBancaria()
        {
            ViewBag.Texto = "Bem-Vindo ao site da Conta Bancária!";
            return View();
        }

        [HttpPost]
        public IActionResult NovaContaBancaria(ContaBancaria obj)
        {
            if (ModelState.IsValid)
            {
                return View("verificacao", obj);
            }
            else
                return View();

        }

        public IActionResult Verificao()
        {
            ViewBag.Texto = "Confirme a sua Conta Bancária";
            return View();
        }

    }
}
