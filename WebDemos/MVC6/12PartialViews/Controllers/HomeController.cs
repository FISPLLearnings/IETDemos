using System.Diagnostics;
using _12PartialViews.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _12PartialViews.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //IEnumerable<SelectList>
            List<Product> productsList = new List<Product>()
            {
                new Product(){Id=1,Name="Laptop",Price=75000, Description="Asus 16GB RAM",Image="~/images/Laptop.jpeg"},
                new Product(){Id=2,Name="HDD",Price=5000, Description="Sandisk 1TB",Image="~/images/HDD.jpg"},
                new Product(){Id=3,Name="Mobile",Price=5000, Description="Nokia, Windows OS",Image="~/images/Mobile.jpg"},
            };
            return View(productsList);
        }
        public IActionResult About()
        {
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
