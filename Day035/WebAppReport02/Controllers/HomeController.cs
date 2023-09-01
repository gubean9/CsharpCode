﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppReport02.Models;

namespace WebAppReport02.Controllers
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

        public IActionResult Test01()
        {
            return View();
        }

        public string Test02(Diary b)
        {
            return "No : " + b.No +
                   " Title : " + b.Title +
                   " Date : " + DateTime.Now;
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