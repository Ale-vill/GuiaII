using Microsoft.AspNetCore.Mvc;
using System;

namespace Guia2.Controllers
{
    [Controller]
    public class PotenciaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(decimal numero, decimal potencia)
        {
            ViewData["resultado"] = Math.Pow((double)numero, (double)potencia);
            return View();
        }
    }
}