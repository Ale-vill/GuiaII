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
            ViewData["result"] = x + y;
            return View();
        }



       
    }
}