using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace _36Threading
{
    //Normal method Time taken = 18342198
    //Thread Object Time taken = 5580596
    //Task Object Time taken = 387848
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Nomal Method Call 
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //for (int i = 0; i < 10; i++)
            //{
            //    DoSomeThingComplex();
            //}
            //watch.Stop();
            //Console.WriteLine("Time taken = {0}", watch.ElapsedTicks); 
            #endregion

            #region Thread 
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //for (int i = 0; i < 10; i++)
            //{
            //    Thread t1 = new Thread(new ThreadStart(DoSomeThingComplex));
            //    t1.Start();
            //   // Console.WriteLine("Current Thread ID:{0}",Thread.CurrentThread.ManagedThreadId);
            //}
            //watch.Stop();
            //Console.WriteLine("Time taken = {0}", watch.ElapsedTicks); 
            #endregion

            #region Explicit Parallel Programming - Multiple Tasks 
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //for (int i = 0; i < 10; i++)
            //{
            //    Task t1 = new Task(new Action(DoSomeThingComplex));

            //    t1.Start();
            //    Console.WriteLine("Current Task ID:{0}",t1.Id.ToString());
            //}
            //watch.Stop();
            //Console.WriteLine("Time taken = {0}", watch.ElapsedTicks); 
            #endregion

            #region Parallel.Foreach - Implicit Parallel Prog.
            ////TPl - Task Parallel Library
            ////Time taken = 775247
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //Parallel.ForEach(arr, (number) =>
            //{
            //    Console.WriteLine($"Number : {number}, Task Id: {Task.CurrentId}, Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            //});
            //watch.Stop();
            //Console.WriteLine("Time taken = {0}", watch.ElapsedTicks); 
            #endregion

            #region Parallel.Foreach - Implicit Parallel Prog. - Thread.Sleep(1000) 
            ////TPl - Task Parallel Library
            ////Time taken = 775247
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //Parallel.ForEach(arr, (number) =>
            //{
            //    Console.WriteLine($"Number : {number}, Task Id: {Task.CurrentId}, Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            //    Thread.Sleep(1000);
            //});
            //watch.Stop();
            //Console.WriteLine("Time taken = {0}", watch.ElapsedTicks); 
            #endregion


            #region MaxDegreeOfParallelism 
            ////TPl - Task Parallel Library
            ////Time taken = 775247
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var options = new ParallelOptions { MaxDegreeOfParallelism = 2 };

            //Parallel.ForEach(arr,options, (number) =>
            //{
            //    Console.WriteLine($"Number : {number}, Task Id: {Task.CurrentId}, Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            //}); 
            #endregion

            #region Exception Handling Using Parrllel.Foreach 
            //var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8,9,10 };
            //try
            //{
            //    Parallel.ForEach(numbers, number =>
            //    {
            //        Console.WriteLine($"Number = {number}, Task Id: {Task.CurrentId}");
            //        if (number == 3)
            //            throw new Exception("Simulated Exception");

            //    });
            //}
            //catch (AggregateException ex)
            //{
            //    foreach (var innerExp in ex.InnerExceptions)
            //    {
            //        {
            //            Console.WriteLine($"Exception : {innerExp.Message} ");
            //        }
            //    }
            //    Console.WriteLine("Parallel Foreach with exception Handling is complete");
            //}
            #endregion

            #region Parallel LINQ

            //List<Emp> allEmployees = new List<Emp>() {
            // new Emp(){ ID =11,Name ="Jignesh", Address ="Patna"},
            // new Emp(){ ID =12,Name ="Prathamesh", Address ="Nashik"},
            // new Emp(){ ID =13,Name ="Devendra", Address ="Nagpur"},
            // new Emp(){ ID =14,Name ="Kalpesh", Address ="Kerla"},
            // new Emp(){ ID =15,Name ="kushendra", Address ="Indore"}
            //};

            //var result = (from emp in allEmployees.AsParallel()
            //              where emp.Address.StartsWith("N")
            //              select emp).ToList();
            //foreach (var emp in result)
            //{
            //    Console.WriteLine($"Name: {emp.Name}, Address: {emp.Address}");
            //}
            #endregion

            #region Task, Async, Await 
            ////Main thread is executing C.W Method
            //Console.WriteLine("Fetching Data....");

            ////call the asynchronous operation and wait for its complition
            //var result = FetchDataAsync().GetAwaiter().GetResult();

            //Console.WriteLine($"Data Fetched : {result}");

            #endregion
        }
        static async Task<string> FetchDataAsync()
        {
            //Simulate the delay to represents asynchronous opertion
            await Task.Delay(2000);

            //Returns the result after delay
            return "Hello EveryOne!!!";
        }
        public static void DoSomeThingComplex()
        {
            for (int i = 0; i < 100000; i++) 
            {
                for(int j = 0; j <  1000;j++)
                {
                    //Nothing here..
                }
            }
        }
    }
    public class Emp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
   
}
