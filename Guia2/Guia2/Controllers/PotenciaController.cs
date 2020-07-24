using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Guia2.Controllers
{
    public class PotenciaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(double numero, double potencia)
        {
            ViewData["resultado"] = Math.Pow(numero, potencia);
            return View();
        }
    }
}