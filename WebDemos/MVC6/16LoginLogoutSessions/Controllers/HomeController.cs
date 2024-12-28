using System.Diagnostics;
using _16LoginLogoutSessions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace _16LoginLogoutSessions.Controllers
{
    public class HomeController : Controller
    {
        private readonly DACDbContext _context;

        public HomeController(DACDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("authUserName") != null)
            {
                return RedirectToAction("Dashboard");
            }
             return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            var authUser =_context.Users.Where(u =>
              u.Name == user.Name && u.Email == user.Email && u.Password == user.Password).FirstOrDefault<User>();
            if(authUser != null)
            {
                HttpContext.Session.SetString("authUserName", user.Name);
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.Message = "Login Failed";
            }
            return View();
        }
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("authUserName") != null)
            {
                string token = HttpContext.Session.GetString("authUserName").ToString();
                ViewBag.UserName = token;
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("authUserName") != null)
            {
                HttpContext.Session.Remove("authUserName");
                return RedirectToAction("Login");
            }
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
