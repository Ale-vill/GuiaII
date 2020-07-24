using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Guia2.Controllers
{
    public class PromedioController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double nota1, double nota2, double nota3)
        {
            ViewData["Resultado"] = Math.Round(nota1 + nota2 + nota3 / 3, 2);

            return View();
        }
    }
}