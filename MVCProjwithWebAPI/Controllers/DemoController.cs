using _0004DemoMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _0004DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            Emp e1 = new Emp() { No = 1, Name = "abc", Address = "pune" };
            Customer c1 = new Customer() { CNo = 100, CName = "chetan" };


            ViewBag.MyCustomer = c1;

            return View("Index", e1);
        }
        [HttpPost]
        public IActionResult Index(Emp e , Customer c, FormCollection frm)
        {
            return null;
        }
    }

}