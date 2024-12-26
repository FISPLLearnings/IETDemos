using Microsoft.AspNetCore.Mvc;

namespace _04ActionMethodReturnTypes.Controllers
{
    public class HomeController : Controller
    {
        //Most Flexible Return Type - can return any type 
        public IActionResult Index()
        {
            return View();
        }
        //generic type - combination of IActionResult and
        //strongly typed responses.
        public ActionResult<string> GetSomeName(string name,string surname)
        {
            string opStr = $"Name = {name}, Surname= {surname}";
            return opStr;
        }
        
        //Lab assignment - figure out URL.
        //public string GetMeSomeString(int id,string str)
        public string GetMeSomeString(int Id,string str)
        {
            //string opStr = $"Id = {id}, str ={str}";
            string opStr = $"Id = {Id}, str ={str}";
            return opStr;
        }

        public JsonResult GetJSONData()
        {
            var data = new {Name= "IET", Address="Pune",
                     Courses = new[] { "C#", "Asp.Net MVC", "Asp.Net Core"}
            };
            return Json(data);
        }
        public ViewResult About()
        {
            return View();
        }

        public FileResult DownloadFile()
        {
            var byteArray = System.IO.File.ReadAllBytes(@"D:\IETCDAC\Dec24\IETCsharpDemos\WebDemos\MVC6\04ActionMethodReturnTypes\Data\quote.pdf");
            return File(byteArray, "application/pdf", "quote.pdf");
        }
        public EmptyResult DoNothing()
        {
            return new EmptyResult();
        }

        public StatusCodeResult GetStatusCode()
        {
            return StatusCode(404);
        }
         public ObjectResult GetSomeObject()
        {
            var obj = new { name = "Mugdha", Address = "Pune" };
            return new ObjectResult(obj);
        }

        [HttpGet("Home/GetDataAsync")]
        public async Task<IActionResult> GetDataAsync()
        {
            await Task.Delay(2000);
            return View("~/Views/Home/GetData.cshtml");
        }
    }
}
