using System.Security.Cryptography;

namespace _29LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //assume this is coming from DB 
            List<Emp> employees = new List<Emp>() { 
                new Emp(){Id = 11, Name="Ganesh", Address="Pune"},
                new Emp(){Id = 12, Name="Gajanan", Address="Punjab"},
                new Emp(){Id = 13, Name="Divyansh", Address="Mumbai"},
                new Emp(){Id = 14, Name="Anup", Address="Pune"},
                new Emp(){Id = 15, Name="Deepali", Address="Patna"},
                new Emp(){Id = 16, Name="Aman", Address="Manipur"},
                new Emp(){Id = 17, Name="Gunjan", Address="Pune"},
                new Emp(){Id = 18, Name="Abhiraj", Address="Indore"},
                new Emp(){Id = 19, Name="Aishwarya", Address="Kolhapur"}
            };

            #region Normal conditinal based filterartion and loops from a collection
            //Console.WriteLine("Enter name of city :");
            //string? city = Console.ReadLine();

            //var FilteredCollection = new List<Emp>();
            //foreach (Emp emp in employees)
            //{
            //    if(emp.Address.ToLower()== city.ToLower())
            //    {
            //        FilteredCollection.Add(emp);
            //    }
            //}

            //foreach (Emp emp in FilteredCollection)
            //{
            //    Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");
            //} 
            #endregion

            #region Normal LINQ Query
            ////selct * from Emp;
            ////"select * from Emp where Address='Pune'"

            ////LINQ - Language Intergrate Query
            ////IEnumerable<Emp> FilteredCollection =(from emp in employees
            ////                                      select emp);
            //Console.WriteLine("Enter name of city :");
            //string city = Console.ReadLine();
            ////IEnumerable<Emp> FilteredCollection = (from emp in employees
            ////                                       where emp.Address.ToLower() == city.ToLower()
            ////                                       select emp);
            //var FilteredCollection = (from emp in employees
            //                          where emp.Address.ToLower() == city.ToLower()
            //                          select emp);

            //foreach (Emp emp in FilteredCollection) 
            //{
            //    Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");
            //} 
            #endregion

            #region Using LINQ Filterartion 
            //Console.WriteLine("Enter name of city :");
            //string? city = Console.ReadLine();
            ////delayed, differed, Lazing Loading of LINQ - 
            ////means LINQ query gets fired when you start using it.
            //var FilteredCollection = (from emp in employees
            //                          where emp.Address.ToLower() == city.ToLower()
            //                          select emp).ToList(); //.ToList() firing LINQ Query

            //employees.Add(new Emp() { Id = 20, Name = "Amit", Address = "Pune" });
            //employees.Add(new Emp() { Id = 21, Name = "Neha", Address = "Kolhapur" });

            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Filtered collection based on {0} city: \n",city);
            //foreach (Emp emp in FilteredCollection) //Foreach is firing Query on LINQ
            //{
            //    Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");
            //}
            #endregion

            #region LINQ filetration based on city and name of Emp
            //Console.WriteLine("Enter name of city :");
            //string? city = Console.ReadLine();

            //var FilteredCollection = (from emp in employees
            //                          where emp.Address.ToLower() == city.ToLower()
            //                          select emp.Name).ToList(); 


            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Filtered collection based on {0} city: \n", city);
            //foreach (var name in FilteredCollection)
            //{
            //    //Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");
            //    Console.WriteLine($"Name = {name}");
            //}
            ////foreach (Emp emp in FilteredCollection)
            ////{
            ////    //Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");
            ////    Console.WriteLine($"Name = {emp.Name}, Address = {emp.Address}");
            ////} 
            #endregion

            #region LINQ filteration based on multiple return values using Holder class
            //Console.WriteLine("Enter name of city :");
            //string? city = Console.ReadLine();

            //var FilteredCollection = (from emp in employees
            //                          where emp.Address.ToLower() == city.ToLower()
            //                          select new Holder()
            //                          { HName = emp.Name,HAddress = emp.Address})
            //                          .ToList();


            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Filtered collection based on {0} city: \n", city);
            ////foreach (var emp in employees)
            ////{
            ////   List< Holder> objlist = new List<Holder>();

            ////    objlist.Add(new Holder() { HName = emp.Name, HAddress = emp.Address });
            ////}
            //foreach (Holder obj in FilteredCollection)
            //{
            //    //Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");
            //    Console.WriteLine($"Name = {obj.HName}, Address = {obj.HAddress}");
            //} 
            #endregion

            #region LINQ filteration based on Anonymous Type  
            //Console.WriteLine("Enter name of city :");
            //string? city = Console.ReadLine();

            //var FilteredCollection = (from emp in employees
            //                          where emp.Address.ToLower() == city.ToLower()
            //                          select new { nm = emp.Name, add = emp.Address })
            //                          .ToList();


            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Filtered collection based on {0} city: \n", city);

            //foreach (var obj in FilteredCollection)
            //{
            //    //Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");
            //    Console.WriteLine($"Name = {obj.nm}, Address = {obj.add}");
            //} 
            #endregion

        }
    }

    public class Holder
    {
        public int HId { get; set; }
        public string HName { get; set; }
        public string HAddress { get; set; }
    }
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
