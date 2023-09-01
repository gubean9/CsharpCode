using EmptyViewImport01.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmptyViewImport01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student{ Id=1, Name="홍길동", HP="010-1111-1111" },
                new Student{ Id=1, Name="이순신", HP="010-2222-2222" },
                new Student{ Id=1, Name="강감찬", HP="010-3333-3333" }
            };
            return View(students);
        }

        public IActionResult About()
        {
            var students = new List<Student>
            {
                new Student{ Id=1, Name="홍길동", HP="010-1111-1111" },
                new Student{ Id=1, Name="이순신", HP="010-2222-2222" },
                new Student{ Id=1, Name="강감찬", HP="010-3333-3333" }
            };
            return View(students);
        }
    }
}
