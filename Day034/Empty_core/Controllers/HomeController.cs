using Microsoft.AspNetCore.Mvc;

namespace Empty_core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
