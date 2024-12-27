using System.Diagnostics;
using _11Validations.Models;
using Microsoft.AspNetCore.Mvc;

namespace _11Validations.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Result(User user)
        {
            if (ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                return View("Index", user);
            }
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
