using System.Collections.Generic;
namespace _16GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List<> 
            //List<int> lst = new List<int>();
            //lst.Add(100);
            //lst.Add(200);
            //lst.Add(300);
            //lst.Add(400);
            //foreach(int item in lst)
            //{
            //    Console.WriteLine(item.ToString());
            //} 
            #endregion

            Customer cust1 = new Customer();
            cust1.Id = 14;
            cust1.Name = "Ben Stiller";
            cust1.Address = "New Jersey";
            Customer cust2 = new Customer();
            cust2.Id = 16;
            cust2.Name = "Hugh Jackman";
            cust2.Address = "New York";
            Customer cust3 = new Customer();
            cust3.Id = 17;
            cust3.Name = "Julia Roberts";
            cust3.Address = "London";

            #region List<Customer> 
            //List<Customer> lstCust = new List<Customer>();
            //lstCust.Add(cust1);
            //lstCust.Add(cust2);
            //lstCust.Add(cust3);
            //foreach (Customer cust in lstCust)
            //{
            //    Console.WriteLine($"Id: {cust.Id}, Name: {cust.Name}, Address: {cust.Address}");
            //} 
            #endregion

           Dictionary<int,Customer> dt =new Dictionary<int,Customer>();
            dt.Add(1, cust1);
            dt.Add(2, cust2);
            dt.Add(3, cust3);
            foreach (var key in dt.Keys)
            {
                Customer cust = dt[key];
                Console.WriteLine($"Id: {dt[key].Id}, Name: {cust.Name}, Address: {cust.Address}");
            }
        }
    }
    public class Customer
    {
        private int _Id;
        private string _Name;
        private string _Address;

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

    }
}
