using Microsoft.AspNetCore.Mvc;

namespace Quiz04.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult BMI()
        {
            return View();
        }
        public IActionResult Cal()
        {
            return View();
        }
    }
}
