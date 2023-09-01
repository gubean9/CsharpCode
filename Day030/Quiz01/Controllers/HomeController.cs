using Microsoft.AspNetCore.Mvc;

namespace Quiz01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
