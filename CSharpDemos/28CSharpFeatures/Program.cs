using System.Collections;
using System.IO.Pipes;

namespace _28CSharpFeatures
{
    public delegate bool MyDelegate(int x);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Partial Classes 
            //CMath obj = new CMath();
            //Console.WriteLine($"Add ={obj.Add(10, 20)} ");
            //Console.WriteLine($"Sub ={obj.Sub(10, 20)} ");
            //obj.SayHi();
            #endregion

            #region Nullable Types 
            // //int? i = null; //Nullable Syntax
            // int? i = 10;
            //// Nullable<int> i = 10;
            // if (i.HasValue) 
            // {
            //     Console.WriteLine($"Value of i = {i}");
            // }
            // else
            // {
            //     Console.WriteLine("Value of i = null");
            // }


            // //if (i == null)
            // //{
            // //    Console.WriteLine("Value of i = null");
            // //}

            // Emp obj = new Emp();
            // obj.Id = 3;
            // obj.Name = "Rohit";
            // obj.Sal = null;
            // obj.Dept = "IT"; 
            #endregion

            #region Anonymous Methods 
            ////Normal Call To a Method
            //Console.WriteLine("Enter a value ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //bool result = Check(input);
            //Console.WriteLine($" {input} is greater than 10 = {result}");

            ////Calling a method via delegate
            //Console.WriteLine("Enter a value ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //MyDelegate del = new MyDelegate(Check);
            //bool result = del(input);
            //Console.WriteLine($" {input} is greater than 10 = {result}");

            //Calling a method via delegate again
            //Console.WriteLine("Enter a value ");
            //int input = Convert.ToInt32(Console.ReadLine());

            ////This is method without Name - Anonymous Method
            //MyDelegate del = delegate (int i)
            //                          {
            //                             return i > 10;
            //                          };
            //bool result = del(input);

            //Console.WriteLine($" {input} is greater than 10 = {result}"); 
            #endregion


            #region Lambada Expression 
            //Console.WriteLine("Enter a value ");
            //int input = Convert.ToInt32(Console.ReadLine());
            ////MyDelegate del = (i)=>
            ////                    {
            ////                        return i > 10;
            ////                    };

            ////MyDelegate del = (i) => { return i > 10;};
            //MyDelegate del = i => i > 10;

            //bool result = del(input);
            //Console.WriteLine($" {input} is greater than 10 = {result}"); 
            #endregion

            #region Predicate Delagete
            //in built delagete 
            //  public delegate bool MyDelegate(int x);
            ////public delegate bool Predicate<in T>(T obj);
            //Console.WriteLine("Enter a value ");
            //int input = Convert.ToInt32(Console.ReadLine());

            //Predicate<int> pointer = i => i > 10;
            //bool result = pointer(input);

            //Console.WriteLine($" {input} is greater than 10 = {result}"); 
            #endregion

            #region Iterator 
            ////int[] numbers = new int[3];
            //ArrayList arr = new ArrayList();
            ////foreach (var item in arr)
            ////{

            ////}
            //Weeks obj =new Weeks();
            //foreach (string day in obj) //1st time : item = "Monday" //2nd  : "Tuesday"
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Implicit Type 
            ////Impicit type can not be declared without initialization
            ////Imlicit type get defination at compile time
            ////Impicit Type belongs to local scope.
            ////Var can not be a return type of a method
            ////You can not declare a method return type as Implicit type - var.
            ////You can not declare a method parameter type as Implicit type - var.

            ////int i = 10;
            //var i = 10; //Defination of var
            //Console.WriteLine(i.GetType().ToString());
            //Emp emp = new Emp();
            //var v = emp;
            //var v1 = new object();
            //var v2 = 23.33;

            //Console.WriteLine("Enter a number ");
            //var choice  = Convert.ToInt32(Console.ReadLine());
            ////var choice  = Console.ReadLine();
            //var result = GetMeSomething(choice); 
            //if(result is int)
            //    Console.WriteLine("result is of type {0}",result.GetType().ToString());
            //if (result is Emp)
            //    Console.WriteLine("result is of type {0}", result.GetType().ToString());
            #endregion

            #region Object Initializer 
            #region .ctor overloadding 
            //Customer obj1 = new Customer();
            //Console.WriteLine($"{obj1.Id}");
            //Console.WriteLine($"{obj1.Name}");
            //Customer obj2 = new Customer("Seema", "Mumbai");
            //Console.WriteLine($"{obj2.Id}");
            //Consoonle.WriteLine($"{obj2.Name}");
            #endregion

            ////Compiler is generating overloadded .ctors for you based on 
            ////property initialization sequence.
            //Customer obj = new Customer() { Name ="Jack",Address="Goa"};
            //Console.WriteLine($"{obj.Name},  {obj.Address}");
            //Customer obj2 = new Customer() { Name = "Jack", Address = "Goa",Id= 200 };
            //Console.WriteLine($"{obj2.Name},  {obj2.Address}, {obj2.Id}");
            #endregion

            #region Auto - Properties 
            //Student s1 = new Student();
            //s1.SName = "Test";
            //s1.SAddress = "Pune";
            //Console.WriteLine($"{s1.SId}, {s1.SName}, {s1.SAddress}");
            //Student s2 = new Student() { SId = 100 , SName="Tom",SAddress="London"};
            #endregion

            #region Anonymous Type 

            //Emp v = new Emp();
            //var v = new Emp() { Id = 10 , Name = "Tom", Dept="IT"};
            //var v1 = new Student() { SId =10, SName= "Pravin",SAddress="Pune"};
            //Compiler is writing names to these Type - Anonymous Types Classes
            //A class without Name
            // var v1 = new { SId =10, SName= "Pravin",SAddress="Pune"};
            // Console.WriteLine(v1.GetType().ToString());
            // var v4 = new { SId = 11, SName = "Ganesh", SAddress = "Goa" };            
            //Console.WriteLine(v4.GetType().ToString());

            // var v5 = new { Id = 13, Name = "Rohit", Address = "Patna" };
            //Console.WriteLine(v5.GetType().ToString());

            // var v3 = new {  SName = "Pravin", SAddress = "Pune", SId = 10 };
            // Console.WriteLine(v3.GetType().ToString());
            //DoSomething(v3);

            //object v2 = new { SName = "Rohit", SAddress = "Mumbai" };
            //var v2 = new { SName = "Rohit", SAddress = "Mumbai" };
            // Console.WriteLine(v2.GetType().ToString());

            #endregion

            #region Extension Methods 
            // int[] arr = { 1, 2, 3, 4, 5 };
            // Console.WriteLine(arr.Max());

            // List<int> lstArr =  arr.MyArrayToList();
            // foreach (int x in lstArr) 
            // {
            //     Console.WriteLine(x);
            // }

            //// MyClass obj = new MyClass();
            // string emailStr = "ab.com";
            // bool result = emailStr.CheckForValidEmail(true);
            // //bool result = MyClass.CheckForValidEmail(emailStr);
            // if (result) 
            // {
            //     Console.WriteLine("Login successful");
            // }
            // else
            // {
            //     Console.WriteLine("Invalid Email");
            // }

            #endregion

            #region Partial Methods 
            //Person obj = new Person();
            //obj.Id = 100;
            //obj.Name = "Tom";
            #endregion

            #region Names and Optional Parameters 
            //Display(11, "Alice", "Pune");
            //Display(20);
            //Display(30, name: "Ganesh", city:"Nashik");
            #endregion
        }

       // public static void Display(int id, string name = "Alice", string city="Pune")
       
        //method implementing optional parameter and Named Parameter feature
        //No need to write .ctors or class for default initialization.
        public static void Display(int id, string name = "Appa" , string city="PMC")
        {
            Console.WriteLine($"{id}, {name}, {city}");
        }
        public static void DoSomething(object obj)
        {
            Console.WriteLine(obj.GetType().ToString());
        }
        public static object GetMeSomething(int choice)
        {

            if (choice > 10)
            {
                return choice * 10;
            }
            else
            {
                return new Emp();
            }
        }
        //public static bool Check(int i)
        //{
        //    return i > 10;
        //}
    }
    public partial class Person
    {
        //Pravin - Developer
        //partial void DoValidate(string NameOfProperty, object ValueOfProperty)
        //{
        //    switch (NameOfProperty)
        //    {
        //        case "Id":
        //            ////some validation logic
        //            break;
        //        case "Name":
        //            ////some validation logic
        //            break;
        //        default:
        //            ////some validation logic
        //            break;
        //    }
        //}
    }
    public partial class Person
    {
        //Partial Methods are private methods to a class
        //Partial methods return type is always void.
        //Partial methods implements partial kyword and
        // these methods always belongs to Partial Classes.
        partial void DoValidate(string NameOfProperty, object ValueOfProperty);


        private int _PId;
        private string _PName;

        public string Name
        {
            get { return _PName; }
            set
            {
                //Rohit - developer
                DoValidate("Name", value);
                _PName = value;
            }
        }

        public int Id
        {
            get { return _PId; }
            set
            {
                //Rohit - developer
                DoValidate("Id", value);
                _PId = value;
            }
        }
    }

    public static class MyClass
    {
        public static List<int> MyArrayToList(this int[] para)
        {
            List<int> lst = new List<int>();
            foreach (int ele in para)
            {
                lst.Add(ele);
            }
            return lst;
        }
        public static bool CheckForValidEmail(this string str, bool nonsenseparameter)
        {
            Console.WriteLine(nonsenseparameter);
            return str.Contains("@") ? true : false;
            //if(str.Contains("@"))
            //{
            //    return true;
            //}
        }
    }

    //For Iterator 
    public class Weeks : IEnumerable
    {
        private string[] days = new string[]
        { "Monday", "Tuesday", "Wednesday", "Thrusday","Friday","Funday" };
        //Collection Initializer

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < days.Length; i++)
            {
                string day = days[i];
                yield return day; //yield keword maintains last index value
            }
        }
    }
    public class Emp
    {
        private int _Id;
        private string _Name;
        private string _Dept;
        //private double? _Sal;
        private Nullable<double> _Sal;

        public double? Sal
        {
            get { return _Sal; }
            set
            {
                _Sal = value;
                //_Sal.HasValue = true;
            }
        }
        public string Dept
        {
            get { return _Dept; }
            set { _Dept = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

    }

    public class Customer
    {
        private int _Id;
        private string _Name;
        private string _Address;
        //35 + properties/ members 
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        //public Customer()
        //{
        //    this.Id = 0;
        //    this._Name = "Bill";
        //    this.Address = "Pune";
        //}
        //public Customer(string nm, string add)
        //{
        //    Name = nm;
        //    Address = add;
        //}
        //public Customer(string add, string nm)
        //{
        //    Name = nm;
        //    Address = add;
        //}
        //public Customer(int id,string nm, string add)
        //{
        //    Id = id;
        //    Name = nm;
        //    Address = add;
        //}
    }

    public class Student
    {
        //Auto - properties : 
        //When there is no need of using private member name in a class or in a assembly
        //then you out source this job to c# compiler.
        //It generated private members - names based on its internal algorithm
        //along with private menber generation- it also genrates
        //getter and setter mthods for it.
        //you can see names in MSIL by ildasm command. 
        //Also you can go for auto peoperties when there is "no need" of
        //data manupulation - data massaging , any logic based on  some condition.
        //kind of Temporary Holder Class.
        public int SId { get; set; }
        public string SName { get; set; }
        public string SAddress { get; set; }


        //private int Name;

        //public int NM
        //{
        //    get { return Name; }
        //    set { Name = value; }
        //}

    }
}
