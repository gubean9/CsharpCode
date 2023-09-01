using Microsoft.AspNetCore.Mvc;

namespace WebAppControler.Controllers
{
    public class FirstController : Controller
    {
        [Route("First")]
        public IActionResult First()
        {
            return View();
        }
        //[Route("About")]
        //public IActionResult About()
        //{
        //    return View();
        //}
    }
}
