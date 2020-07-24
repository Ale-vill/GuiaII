using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;

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
        public IActionResult Index(decimal nota1, decimal nota2, decimal nota3)
        {
           
            var promedio = Math.Round((nota1+nota2+nota3) / 3, 2);

            var mensaje = string.Empty;
            ViewData["claseCss"] = string.Empty;

            if (promedio == 10)
            {
                mensaje = "Felicidades su nota es: " + promedio;
                ViewData["claseCss"] = "alert alert-success";
            }
            else if (promedio < 10 && promedio >= 7)
            {
                mensaje = "Aprobado su nota es: " + promedio;
                ViewData["claseCss"] = "alert alert-primary";
            }
            else if (promedio < 10 && promedio >= 7)
            {
                mensaje = "Aprobado su nota es: " + promedio;
                ViewData["claseCss"] = "alert alert-warning";
            }
            else if (promedio < 7 && promedio > 4)
            {
                mensaje = "Reprobado su nota es: " + promedio;
                ViewData["claseCss"] = "alert alert-info";
            }
            else if (promedio <= 4)
            {
                mensaje = "Visite a su tutor, su promedio es: " + promedio;
                ViewData["claseCss"] = "alert alert-danger";
            }
            else
            {
                mensaje = "Error: Verifique los datos ingresados";
                ViewData["claseCss"] = "alert alert-danger";
            }

            ViewData["resultado"] = mensaje;

            return View();
        }
    }
}