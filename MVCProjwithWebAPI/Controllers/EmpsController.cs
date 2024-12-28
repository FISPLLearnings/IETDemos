using _0004DemoMVC.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace _0004DemoMVC.Controllers
{
    //    https://blog.sqlauthority.com/
    //https://www.dotnetcurry.com/
    //https://learn.microsoft.com/
    //https://www.indiabix.com/
    //https://www.sanfoundry.com/
    //https://www.johnpapa.net/
    //https://learn.microsoft.com/en-us/shows/csharp-for-beginners/


    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class EmpsController : ControllerBase
    {
        MyDB db = new MyDB();

        // GET: api/Emps
        [HttpGet]
        //public IEnumerable<object> Get()
        public IEnumerable<Emp> Get()
        {
            return db.Emps.ToList();
            //var result = (from e in db.Emps
            //              where e.Name.Contains("j")
            //              select new { Eno = e.No , Ename = e.Name }).ToList();
        }

        // GET api/Emps/5
        [HttpGet("{id}")]
        public Emp Get(int id)
        {
            return db.Emps.Find(id);
        }

        // POST api/Emps
        [HttpPost]
        public void Post([FromBody] Emp empToBeAdded)
        {
            db.Emps.Add(empToBeAdded);
            db.SaveChanges();
        }

        // PUT api/Emps/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Emp empUpdated)
        {
            var empToUpdate = db.Emps.Find(id);
            empToUpdate.Name = empUpdated.Name;
            empToUpdate.Address = empUpdated.Address;
            db.SaveChanges();
        }

        // DELETE api/Emps/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var empToRemove = db.Emps.Find(id);
            db.Emps.Remove(empToRemove);
            db.SaveChanges();
        }
    }
}
