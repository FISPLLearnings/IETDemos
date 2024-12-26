using Microsoft.AspNetCore.Mvc;

namespace _02DefaultController.Controllers
{
    public class HomeController : Controller
    {
        //Action MEthods - default public 
        public IActionResult Index()
        {
            return View();
        }
    }
}
