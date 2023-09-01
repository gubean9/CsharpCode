using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly StudentDbContext _studentDb;
        public HomeController(StudentDbContext studentDb)
        {
            this._studentDb = studentDb;
        }


        public IActionResult Index()
        {
            var stdData = _studentDb.Student.ToList();
            return View(stdData);
        }

        // GET: 삽입화면
        public IActionResult Create()
        {
            return View();
        }

        // POST: 삽입기능
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Hp")] Student student)
        {
            if (ModelState.IsValid)
            {
                _studentDb.Add(student);
                await _studentDb.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        //삭제
        [HttpPost]
        public async Task<IActionResult> DeleteSelected(List<int> selectedStudents)
        {
            var studentsToDelete = _studentDb.Student.Where(s => selectedStudents.Contains(s.Id)).ToList();

            _studentDb.Student.RemoveRange(studentsToDelete);
            await _studentDb.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        //수정
        public IActionResult Update(Student std)
        {
            //수정해야 함
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