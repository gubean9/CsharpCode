using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFactory_MinProject.Models;
using System.Diagnostics;

namespace SmartFactory_MinProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly CodeboardDbContext _context;

        public HomeController(CodeboardDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            //넘어온 세션의 값이 null일 경우 Login페이지로 바로 가기
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                //세션의 내용을 ViewBag에 담습니다.
                ViewBag.MySession = HttpContext.Session.GetString("UserSession").ToString();
            }

            return View();
        }
        
        [HttpPost]
        public IActionResult Login(User user)
        {
            //SqlServer에 있는 Id/password와 폼에서 입력한 id/password를 비교합니다.
            var myUser = _context.User.Where(
                x => x.AccountId == user.AccountId &&
                     x.AccountPassword == user.AccountPassword)
                .FirstOrDefault();

            if (myUser != null)
            {
                //세션을 만드는 코드 입니다.
                //세션의 정보를 [Key, Value] 조합으로 만듭니다. Key는 UserSession이란 단어 Value는 DB에 있는 email 값입니다.
                HttpContext.Session.SetString("UserSession", myUser.AccountId);

                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.Message = "로그인 실패";
            }

            return View();
        }

        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                //세션정보를 삭제합니다.
                HttpContext.Session.Remove("UserSession");
                //return RedirectToAction("Login", "Home");  //로그아웃 후 바로 로그인 화면으로 이동
            }
            return View();
        }
        public IActionResult DashBoard()
        {
            //넘어온 세션의 값이 null이 아닐 경우 즉, 로그인 작업으로 세션이 만들어져 있는 경우
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                //세션의 내용을 ViewBag에 담습니다.
                ViewBag.MySession = HttpContext.Session.GetString("UserSession").ToString();
            }
            else
            {
                return RedirectToAction("Login");
            }
            return View();
        }


        public async Task<IActionResult> Index()
        {
            var codeboard = await _context.Codeboard.ToListAsync<Codeboard>();
            return View(codeboard);
        }
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(Codeboard codeboard)
        {
            if (ModelState.IsValid)
            {
                await _context.Codeboard.AddAsync(codeboard);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(codeboard);
        
        }

        [HttpPost]
        public IActionResult ValidateModel(Codeboard codeboard)
        {
            if (ModelState.IsValid)
            {
                return Json(new { isValid = true });
            }

            var errors = ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage)
                .ToList();

            return Json(new { isValid = false, errors });
        }







        public IActionResult Details(int? id)
        {
            if (id == null || _context.Codeboard == null)
            {
                return NotFound();
            }
            var codeboard = _context.Codeboard
				.Include(c => c.Comments) // 댓글들을 가져오기 위해 Include 사용
				.FirstOrDefault(x => x.Id == id);

            if (codeboard == null)
            {
                return NotFound();
            }
            return View(codeboard);
        }


        
		[HttpPost]
		public IActionResult AddComment(int id, string content)
		{
			var codeboard = _context.Codeboard.Find(id);
			if (codeboard != null)
			{
				var comment = new Comment
				{
					Content = content,
					Date = DateTime.Now,
					CodeboardId = id
				};

				_context.Comments.Add(comment);
				_context.SaveChanges();
			}

			return RedirectToAction("Details", new { id });
		}
        



		public IActionResult Edit(int? id)
        {
            if (id == null || _context.Codeboard == null)
            {
                return NotFound();
            }
            var codeboard = _context.Codeboard.Find(id);

            if (codeboard == null)
            {
                return NotFound();
            }
            return View(codeboard);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Codeboard std)
        {
            if (ModelState.IsValid)
            {
                _context.Update(std);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(std);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || _context.Codeboard == null)
            {
                return NotFound();
            }
            var stdData = _context.Codeboard.FirstOrDefault(x => x.Id == id);

            if (stdData == null)
            {
                return NotFound();
            }
            return View(stdData);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {
            var stdData = _context.Codeboard.Find(id);

            if (stdData != null)
            {
                _context.Codeboard.Remove(stdData);
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
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