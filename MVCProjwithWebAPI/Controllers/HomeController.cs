using _0004DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace _0004DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        MyDB db = new MyDB();
        //public IActionResult Index()
        //{
        //    return new JsonResult(db.Emps.ToList());
        //}

        public IActionResult Index()
        {
            //db.Customers.Add(new Customer() { CName = "Hitesh", CNo = 10 });
            //db.Customers.Add(new Customer() { CName = "Mitesh", CNo = 20 });
            //db.Customers.Add(new Customer() { CName = "Gitesh", CNo = 30 });
            //db.SaveChanges();

            return new JsonResult(db.Customers.ToList());
            //return Redirect("/About");
        }
    }
}
