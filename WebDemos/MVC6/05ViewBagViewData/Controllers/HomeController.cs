using _05ViewBagViewData.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05ViewBagViewData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string[] Days = new string[] { 
            "Saturday", "Funday","Sunday"
            };
            //belongs to same action method and can not be accessed
            //in another or diff action methods 
            ViewData["WeekDays"] = Days;

            Emp emp = new Emp() {Id=11, Name="Ritesh",Address="Pune" };
            //ViewBag.Key = Value;
            //belongs to same action method and can not be accessed
            //in another or diff action methods 
            ViewBag.EmpData = emp;
            //One time data transfer
            TempData["Message"] = "Hello";

            return View();
        }

        public IActionResult About()
        {
            //ViewBag used ViewData internally.
            //Hence can not keep keys same for both the types
            ViewData["Msg"] = "Hi";
            ViewBag.Msg = "Bye";
            return View();
        }
    }
}
