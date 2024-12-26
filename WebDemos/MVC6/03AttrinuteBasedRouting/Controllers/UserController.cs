using Microsoft.AspNetCore.Mvc;

namespace _03AttrinuteBasedRouting.Controllers
{
    [Route("[controller]")] //Tokens 
    public class UserController : Controller
    {
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("[action]/{id?}")]
        public int GetNumber(int? id)
        {
            return id ??= 555;
        }
        //Null- coleacing operator
        // ?? - instead of null some default set value - return 
        //e.g : id ?? 555; -return default value 555  
        //Assignment Null- coleacing operator
        //??= -instead of null id will be assigned by default value 
        //e.g: id ??= 555; // id = 555; - return as default value
    }
}
