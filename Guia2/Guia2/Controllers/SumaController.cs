using Microsoft.AspNetCore.Mvc;

namespace Guia2.Controllers
{
    
    public class SumaController : Controller
    {
        [HttpGet]
        // GET: Suma
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(decimal x, decimal y)
        {
            ViewData["result"] = $"Resultado: {x + y}";
            ViewData["style"] = "alert-success";
            return View();
        }



       
    }
}