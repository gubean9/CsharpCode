using Microsoft.AspNetCore.Mvc;
using Quiz01.Models;
using System.Diagnostics;
using System.Text;

namespace Quiz01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Result(int Count)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < Count; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    sb.Append("*");
                }
                sb.Append("<br />");
            }
            return View("Result", sb.ToString());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}