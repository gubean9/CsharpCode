using Microsoft.AspNetCore.Mvc;

namespace WebEmpty_Test01.Controllers
{
    public class MyController : Controller
    {
        [Route("/")]
        public IActionResult Help()
        {
            return View();
        }
    }
}
