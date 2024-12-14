namespace _10OOPProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            //Console.WriteLine("Enter Emp Id ");
            //int id = Convert.ToInt32(Console.ReadLine());
            //emp.EId = id;
            //Console.WriteLine("You entered Emp ID as : {0}", emp.EId);
            //Console.WriteLine("Enter Name of Emp");
            //emp.EName = Console.ReadLine();
            //Console.WriteLine("Name of Emp is : {0}", emp.EName);
            //emp.logger = new Logger();
            //emp.logger.Log();
            string deptname = emp.Dept;
            Console.WriteLine(deptname);
            

            #region getter, setter 
            //emp.set_EId(10);
            //Console.WriteLine(emp.get_EID()); 
            #endregion
        }
    }
    public class Employee
    {
        private int _EID;
        private string _EName;
        private Logger _logger;
        private string _Dept;

        //Properties Syntax
        public int EId
        {
            set
            {
                _EID = value;
            }
            get
            {
                return _EID;
            }
        }
        public string EName
        {
            set
            {
                _EName = value;
            }
            get
            {
                _EName = "Mr." + _EName;
                return _EName;
            }
        }

        public Logger logger
        {
            set
            {
                
                _logger = value;
            }
            get
            {
                return _logger;
            }
        }

        public string Dept
        {
            get
            {
                _Dept = "HR";
                return _Dept;
            }
        }
        #region getter , setter 
        //public void set_EId(int id)
        //{
        //    this._EID = id;
        //}
        //public int get_EID() 
        //{
        //    return this._EID;
        //} 
        #endregion
    }
    public class Logger
    {
        public void Log()
        {
            //..code
            Console.WriteLine("Logger method output");
        }
    }
}
