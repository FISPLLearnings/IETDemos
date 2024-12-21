using System.Diagnostics;
using System.Linq.Expressions;

namespace _30LINQ
{
   // public delegate bool MyDelegate(int i);
    public delegate bool MyDelegate(Emp e,string pointer);

    public delegate void YourDelegate();
    public delegate T2 MyDel1<T1,T2>(T1 para1);
    public delegate Toutput MyDel1<Pinput1, Pinput2,Toutput>(Pinput1 para1, Pinput2 para2);
    public delegate Toutput MyDel1<Pinput1, Pinput2, Pinput3,Toutput>(Pinput1 para1, Pinput2 para2, Pinput3 para3);
    internal class Program
    {
        static void Main(string[] args)
        {
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



            #region MyWhere method with MyDlegate function Pointer
            //MyDelegate pointer = new MyDelegate(ConditionalCheck);

            //var fileteredCollection = MyWhere(employees, pointer);
            ////var fileteredCollection = MyWhere(employees, 
            ////    (emp,city)
            ////    =>
            ////    (emp.Address.ToLower() == city.ToLower())
            ////    );

            //foreach (Emp emp in fileteredCollection)
            //{
            //    Console.WriteLine($"{emp.Id}, {emp.Name}, {emp.Address}"); 
            // }
            #endregion

            #region My own overloadded generic delgates 
            //MyDel1<int, int, int> pointer = new MyDel1<int, int, int>((x, y) => x + y);
            //Console.WriteLine($"Result  = {pointer(10,20)}"); 
            #endregion

            #region Action, Action<>, Func<> - in built delagates 
            //////Action pointer = new Action(() =>
            //////{
            //////    Console.WriteLine("Hello");
            //////});
            //////pointer();

            ////Action<int, int,int> pointer = (x, y, p) =>
            ////{
            ////    int result = x + y;
            ////    Console.WriteLine(result);
            ////};
            //pointer(10, 20);

            //Func<int, int, int> pointer = (x, y) =>
            //{
            //    int result = x + y;
            //    return result;
            //};
            //pointer(10, 20);
            #endregion

            Stopwatch watch = new Stopwatch();
            #region Normal method call 
            //watch.Start();
            //bool result = Check(100); //358 
            //watch.Stop();
            //Console.WriteLine(result);
            //Console.WriteLine("Time taken  = {0}", watch.ElapsedTicks); 
            #endregion

            #region Using MyDelegate Check() call
            //MyDelegate pointer = new MyDelegate(Check);
            //watch.Start();
            //bool result = pointer(100); //358 
            //watch.Stop();
            //Console.WriteLine(result);//551
            //Console.WriteLine("Time taken  = {0}", watch.ElapsedTicks); 
            #endregion

            #region Mydeleagte using Lambada expression 
            //MyDelegate pointer = new MyDelegate((i) => i > 10);
            //watch.Start();
            //bool result = pointer(100); //358 //551 //198
            //watch.Stop();
            //Console.WriteLine(result);
            //Console.WriteLine("Time taken  = {0}", watch.ElapsedTicks); 
            #endregion

            #region Func<> with Lambada Expression
            //Func<int,bool> pointer = i => i > 10;
            //watch.Start();
            //bool result = pointer(100); //358 //551 //198 //326
            //watch.Stop();
            //Console.WriteLine(result);
            //Console.WriteLine("Time taken  = {0}", watch.ElapsedTicks); 
            #endregion

            #region Expression Tree 
            //// Func<int, bool> pointer = i => i > 10;
            //Expression<Func<int, bool>> tree = i => i > 10;
            //Func<int, bool> pointer = tree.Compile();
            //watch.Start();
            //bool result = pointer(100); //358 //551 //198 //326 -- //23
            //watch.Stop();
            //Console.WriteLine(result);
            //Console.WriteLine("Time taken  = {0}", watch.ElapsedTicks); 
            #endregion

            List<string> lst = new List<string>() { "Dipak","Mihir","Dilip"};
            var result = lst.Select(x =>  x.ToUpper() );
            foreach (var item in result) 
            {
                Console.WriteLine(item);
            }
            var names = lst.Where(str => str.ToLower().StartsWith("d"));
            foreach (var nm in names)
            {
                Console.WriteLine(nm);
            }

            //var filteredCollection = .from().Where().Select().ToList();
        }
        public static bool Check(int i)
        {
            return i > 10;
        }
        public static List<Emp> MyWhere(IEnumerable<Emp> empList, MyDelegate pointer)
        {
            Console.WriteLine("Enter city");
            string? city = Console.ReadLine();

            List<Emp> fileteredCollection = new List<Emp>();
            foreach (Emp emp in empList)
            {
                if (pointer(emp, city))
                {
                    fileteredCollection.Add(emp);
                }
            }
            return fileteredCollection;
        }
        public static bool ConditionalCheck(Emp emp , string city)
        {
            return (emp.Address.ToLower() == city.ToLower());
        }
    }
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
