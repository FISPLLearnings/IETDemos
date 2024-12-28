using System.Diagnostics;
using _13ConntedInMVC.DAL;
using _13ConntedInMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace _13ConntedInMVC.Controllers
{
    public class HomeController : Controller
    {

        

        public IActionResult Index()
        {
            IETDbContext dbContext = new IETDbContext();
            var allEmployees = dbContext.SelectRecords();
            return View(allEmployees);
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
