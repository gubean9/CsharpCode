using Microsoft.AspNetCore.Mvc;

namespace Quiz03.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
