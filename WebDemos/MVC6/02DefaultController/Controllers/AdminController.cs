using Microsoft.AspNetCore.Mvc;

namespace _02DefaultController.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
