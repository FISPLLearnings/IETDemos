using _10TagHelpers.Models;
using Microsoft.AspNetCore.Mvc;

namespace _10TagHelpers.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult<string> GetUserDetails(NewUser user)
        {
            if (ModelState.IsValid)
            {
                string deatils = $"Name: {user.Name}, Address: {user.Address}, Age: {user.Age}, Gender: {user.Gender}, Mobile: {user.PhNo}, Email: {user.Email}, Marital Status: {user.isMarried}, Enquiry: {user.Enquiry}";
                return deatils;
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
