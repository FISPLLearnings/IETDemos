using System.Collections;

namespace _14Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region int [] 
            //int[] arr = new int[5];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;
            //arr[4] = 5;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //} 
            #endregion

            #region string [] 
            //string[] arr2 = new string[3];
            //arr2[0] = "Priti";
            //arr2[1] = "Appa";
            //arr2[2] = "Tina";

            //foreach(string str in arr2)
            //{
            //    Console.WriteLine(str);
            //} 
            #endregion

            #region Emp [] 
            //Emp emp1 = new Emp();
            //emp1.Id = 1;
            //emp1.Name = "Suresh";
            //emp1.Address = "Pune";
            //Emp emp2 = new Emp();
            //emp2.Id = 2;
            //emp2.Name = "Ramesh";
            //emp2.Address = "mumbai";

            //Emp[] empArr = new Emp[2];
            //empArr[0] = emp1;
            //empArr[1] = emp2;

            ////foreach(Emp emp in empArr)
            ////{
            ////    string result = string.Format("Id = {0}, Name = {1}, Address = {2}",
            ////        emp.Id, emp.Name, emp.Address);
            ////    Console.WriteLine(result);
            ////}

            //foreach (var emp in empArr)
            //{
            //    string result = string.Format("Id = {0}, Name = {1}, Address = {2}",
            //        emp.Id, emp.Name, emp.Address);
            //    Console.WriteLine(result);
            //} 
            #endregion


            Emp emp1 = new Emp();
            emp1.Id = 1;
            emp1.Name = "Suresh";
            emp1.Address = "Pune";

            Book book = new Book();
            book.BookName = "Shiva Triology";
            book.BookAuthor = "Amish";

            #region object [] 
            //object[] objArr = new object[5];
            //objArr[0] = 100; // Boxing
            //objArr[1] = 23.33;
            //objArr[2] = emp1; //Type- casting
            //objArr[3] = "someData";
            //objArr[4] = book;


            //foreach (object item in objArr)
            //{
            //    if (item is int)
            //    {
            //        int i = Convert.ToInt32(item); //Unboxing
            //        Console.WriteLine(i.ToString());
            //    }
            //    if (item is double)
            //    {
            //        double d = Convert.ToDouble(item);
            //        Console.WriteLine(d.ToString());
            //    }
            //    if (item is string)
            //    {
            //        string str = item.ToString();
            //        Console.WriteLine(str);
            //    }
            //    if(item is Emp)
            //    {
            //        Emp emp = item as Emp;
            //        string result = string.Format("Id = {0}, Name = {1}, Address = {2}",
            //        emp.Id, emp.Name, emp.Address);
            //        Console.WriteLine(result);
            //    }
            //    if(item is Book)
            //    {
            //        Book book1 = item as Book;
            //        string result = string.Format("Book Name = {0}, Author = {1}",
            //                                            book1.BookName, book1.BookAuthor );
            //        Console.WriteLine(result);
            //    }
            //} 
            #endregion

            #region ArrayList 
            //ArrayList arr = new ArrayList(); 
            //arr.Add(100);
            //arr.Add("something");
            //arr.Add(emp1);
            //arr.Add(book);
            //arr.Add(23.33);
            //arr.Add(23333.5555533);

            //foreach (object item in arr)
            //{
            //    if (item is int)
            //    {
            //        int i = Convert.ToInt32(item); //Unboxing
            //        Console.WriteLine(i.ToString());
            //    }
            //    if (item is double)
            //    {
            //        double d = Convert.ToDouble(item);
            //        Console.WriteLine(d.ToString());
            //    }
            //    if (item is string)
            //    {
            //        string str = item.ToString();
            //        Console.WriteLine(str);
            //    }
            //    if (item is Emp)
            //    {
            //        Emp emp = item as Emp;
            //        string result = string.Format("Id = {0}, Name = {1}, Address = {2}",
            //        emp.Id, emp.Name, emp.Address);
            //        Console.WriteLine(result);
            //    }
            //    if (item is Book)
            //    {
            //        Book book1 = item as Book;
            //        string result = string.Format("Book Name = {0}, Author = {1}",
            //                                            book1.BookName, book1.BookAuthor);
            //        Console.WriteLine(result);
            //    }
            //} 
            #endregion

            #region Hashtable 
            //Hashtable ht = new Hashtable();
            //ht.Add(1, 10);
            //ht.Add(2, "pqr");
            //ht.Add(3, emp1);
            //ht.Add(4,23.33);
            //foreach(var key in ht.Keys)
            //{
            //    //Console.WriteLine(ht[key]);
            //    if (ht[key] is int)
            //    {
            //        int i = Convert.ToInt32(ht[key]);
            //        Console.WriteLine("Key ={0}, Value = {1}", key, i);
            //    }
            //    if (ht[key] is string)
            //    {
            //        string str = Convert.ToString(ht[key]);
            //        Console.WriteLine("Key ={0}, Value = {1}", key, str);
            //    }
            //    if (ht[key] is double)
            //    {
            //        double d = Convert.ToDouble(ht[key]);
            //        Console.WriteLine("Key ={0}, Value = {1}", key, d);
            //    }
            //    if (ht[key] is Emp)
            //    {
            //        Emp emp = ht[key] as Emp;
            //        string result = string.Format(" [Id = {0}, Name = {1}, Address = {2}]",
            //                emp.Id, emp.Name, emp.Address);
            //        Console.WriteLine("Key ={0}, Value = {1}", key, result);
            //    } 
            // }
            #endregion

            #region Stack 
            //Stack st = new Stack();
            //st.Push(10);
            //st.Push(20);
            //st.Push(30);
            //st.Pop();
            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Queue
            //Queue queue = new Queue();
            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region indices and range 
            //int[] array = new int[5];
            //array[0] = 1;
            //array[1] = 2;
            //array[2] = 3;
            //array[3] = 4;
            //array[4] = 5;

            ////Accessing elemnets with indices
            //Console.WriteLine("Last Element = {0}", array[^1]);
            //Console.WriteLine("SecondLast Element = {0}", array[^2]);

            ////Accessing elemnets with range
            ////string str = string.Join(",", array);
            ////Console.WriteLine(str);

            //int[] subArray1= array[1..3];
            //Console.WriteLine("range [1..3]  = "+ string.Join(",",subArray1));
            //int[] subArray2= array[..3];
            //Console.WriteLine("range [..3]  = "+ string.Join(",",subArray2));
            #endregion


            //Tuples - no need to declare a class and size of array is fixed
            var person = Display(100, "Tim", "London");
            Console.WriteLine(person);
            Console.WriteLine(person.nm);
        }
        public static (int Id, string nm, string add) Display(int id, string name,string Address)
        {
            int Id = id;
            string nm = name;
            string add = Address;
            return (Id,nm,add);
        }
    }

    public class Book
    {
        private string _BookName;
        private string _BookAuthor;

        public string BookAuthor
        {
            get { return _BookAuthor; }
            set { _BookAuthor = value; }
        }

        public string BookName
        {
            get { return _BookName; }
            set { _BookName = value; }
        }

    }
    public class Emp
    {
        private int _EId;
        private string _EName;
        private string _EAddress;

        public string Address
        {
            get { return _EAddress; }
            set { _EAddress = value; }
        }


        public string Name
        {
            get { return _EName; }
            set { _EName = value; }
        }


        public int Id
        {
            get
            {
                return _EId;
            }
            set { _EId = value; }
        }

    }
}
