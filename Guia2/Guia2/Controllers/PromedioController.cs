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
           
            var promedio = Math.Round((nota1 + nota2 + nota3) / 3, 2);
            
            string mensaje="";
            if (promedio==10)
            {
                mensaje = "Felicidades su nota es:"+promedio;
            }
            if (promedio<10 && promedio>=7)
            {
                mensaje = "Aprobado su  nota es:"+promedio;
            }
            if (promedio < 10 && promedio >= 7)
            {
                mensaje = "Aprobado su  nota es:"+promedio;
            }
            if (promedio < 7 && promedio >4)
            {
                mensaje = "Reprobado su  nota es:"+promedio;
            }
            if (promedio <= 4)
            {
                mensaje = "Visite a su tutor"+promedio;
            }

            ViewData["resultado"] = mensaje;

            return View();
        }
    }
}