﻿using Diary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Diary.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly DiaryDB diaryDB;
        public HomeController(DiaryDB diary)
        {
            this.diaryDB = diary;
        }

        public IActionResult Index()
        {
            var diarydata = diaryDB.logs.ToList();
            return View();
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