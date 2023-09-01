using Microsoft.AspNetCore.Mvc;

namespace Quiz02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
