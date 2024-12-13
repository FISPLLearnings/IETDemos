namespace _08OOPLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Tell us what do you wanr: 1. SQL Server, 2. Oracle, 3.MySQL");
                int choice = Convert.ToInt32(Console.ReadLine());
                DatabaseFactory database = new DatabaseFactory();
                IDatabase someDB = database.GetSomeDatabase(choice);

                Console.WriteLine("Tell us operation choice: 1. Insert, 2. Update, 3.Delete");
                int opChoice = Convert.ToInt32(Console.ReadLine());
                switch (opChoice)
                {
                    case 1:
                        someDB.Insert();
                        break;
                    case 2:
                        someDB.Update();
                        break;
                    case 3:
                        someDB.Delete();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
                Console.WriteLine("Do you want to continue? y/n");
                string ynChoice = Console.ReadLine();
                if(ynChoice == "n")
                {
                    break;
                }
            }
        }
    }

    public interface IDatabase
    {
        void Insert();
        void Update();
        void Delete();
    }

    public class DatabaseFactory //Object producing factory classes
    {
        public IDatabase GetSomeDatabase(int choice)
        {
            IDatabase someDatabase = null;
            switch (choice)
            {
                case 1:
                    someDatabase = new SQLServer();
                    break;
                case 2:
                    someDatabase = new Oracle();
                    break;
                case 3:
                    someDatabase = new MySQL();
                    break;
                default:
                    someDatabase = null;
                    break;
            }
            return someDatabase;
        }
    }
    public class SQLServer : IDatabase
    {
        private Logger _logger;
        public SQLServer()
        {
            _logger = Logger.GetLogger();
        }
        public void Insert()
        {
            //code 
            Console.WriteLine("Insert done in SQL Server Database");
            _logger.Log("Insert happened in SQL Server successfully");

        }
        public void Update()
        {
            //code 
            Console.WriteLine("Update done in SQL Server Database");
            _logger.Log("Update happened in SQL Server successfully");
        }
        public void Delete()
        {
            //code 
            Console.WriteLine("Delete done in SQL Server Database");
            _logger.Log("Delete happened in SQL Server successfully");

        }
    }
    public class Oracle : IDatabase
    {
        private Logger _logger;
        public Oracle()
        {
            _logger = Logger.GetLogger();
        }
        public void Insert()
        {
            //code 
            Console.WriteLine("Insert done in Oracle Database");
            _logger.Log("Insert happened in Oracle successfully");
        }
        public void Update()
        {
            //code 
            Console.WriteLine("Update done in Oracle Database");
            //_logger.Log("Update happened in Oracle successfully");
        }
        public void Delete()
        {
            //code 
            Console.WriteLine("Delete done in Oracle Database");
            _logger.Log("Delete happened in Oracle successfully");
        }
    }
    public class MySQL : IDatabase
    {
        private Logger _logger;
        public MySQL()
        {
            _logger = Logger.GetLogger();
        }
        public void Delete()
        {
            //code 
            Console.WriteLine("Delete done in MySQL Database");
            _logger.Log("Delete happened in MySQL successfully");
        }

        public void Insert()
        {
            //code 
            Console.WriteLine("Insert done in MySQL Database");
            _logger.Log("Insert happened in MySQL successfully");
        }

        public void Update()
        {
            //code 
            Console.WriteLine("Update done in MySQL Database");
            _logger.Log("Update happened in MySQL successfully");
        }
    }
    public class Logger
    {
        private static Logger logger=new Logger();
        //private static Logger logger2=new Logger();
        //private static Logger logger3=new Logger();
        private Logger()
        {
            Console.WriteLine("Logger object created for the first time...");
        }
        public static Logger GetLogger() //Factory Method
        { 
            return logger; 
        }
        public void Log(string message)
        {
            Console.WriteLine("--- Logged: "+ message+" "+ DateTime.Now.ToString());
        }
    }
}
