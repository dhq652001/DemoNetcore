using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.hello = "bo m la nhat";
            return View();
        }
        public IActionResult XYZ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult XYZ(string Xyz)
        {
            ViewBag.ep = Xyz;
            return View();
        }

    }
}