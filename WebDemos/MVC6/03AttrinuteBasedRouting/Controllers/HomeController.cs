using Microsoft.AspNetCore.Mvc;

namespace _03AttrinuteBasedRouting.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("")]
        //[Route("Home")]
        [Route("Index")]
        [Route("~/")]
        //[Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }

        //[Route("Home/About")]
        [Route("About")]
        public IActionResult About()
        {
            return View();
        }
    }
}
