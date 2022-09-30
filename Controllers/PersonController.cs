using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Hi = " Ten gi cung duoc";
            return View();
        }
        public  IActionResult ABC()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult ABC(string Abc)

        {
            ViewBag.Hu = Abc;
            return View();
        }
    }
}