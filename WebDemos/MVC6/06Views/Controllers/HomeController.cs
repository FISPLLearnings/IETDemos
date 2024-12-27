using _06Views.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace _06Views.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Emp emp = new Emp() { Id= 11, Name="Neha",Address="Nagpur"};
            Cust cust = new Cust() { Id= 22, Name= "Prachi",Address="Pune"};
            ArrayList arr = new ArrayList() { emp,cust};
            return View(arr);

           // return View(emp,cust);//Not allowed
        }
    }
}
