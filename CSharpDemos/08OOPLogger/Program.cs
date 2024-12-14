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
                Database someDB = database.GetSomeDatabase(choice);

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

    public abstract class Database
    {
        public Logger _logger;
        public Database()
        {
            _logger = Logger.GetLogger();
        }
        protected abstract void DoInsert();
        protected abstract void DoUpdate();
        protected abstract void DoDelete();
        protected abstract string GetDatabaseName();

        string logMsg = null;
        public void Insert()
        {
            DoInsert();
            logMsg = string.Format("Insert happened in {0} successfully", GetDatabaseName());
            _logger.Log(logMsg);
        }
        public void Update()
        {
            DoUpdate();
            _logger.Log("Update happened in "+ GetDatabaseName()+ " successfully");
        }
        public void Delete()
        {
            DoDelete();
            _logger.Log("Delete happened in "+ GetDatabaseName()+ "  successfully");
        }
    }

    public class DatabaseFactory //Object producing factory classes
    {
        public Database GetSomeDatabase(int choice)
        {
            Database someDatabase = null;
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
    public class SQLServer : Database
    {
        protected override string GetDatabaseName()
        {
            return "SQL Server";
        }
        protected override void DoInsert()
        {
            //code 
            Console.WriteLine("Insert done in SQL Server Database");

        }
        protected override void DoUpdate()
        {
            //code 
            Console.WriteLine("Update done in SQL Server Database");
        }
        protected override void DoDelete()
        {
            //code 
            Console.WriteLine("Delete done in SQL Server Database");
        }
    }
    public class Oracle : Database
    {
        protected override string GetDatabaseName()
        {
            return "Oracle";
        }
        protected override void DoInsert()
        {
            //code 
            Console.WriteLine("Insert done in Oracle Database");
        }
        protected override void DoUpdate()
        {
            //code 
            Console.WriteLine("Update done in Oracle Database");
        }
        protected override void DoDelete()
        {
            //code 
            Console.WriteLine("Delete done in Oracle Database");
        }
    }
    public class MySQL : Database
    {
        protected override string GetDatabaseName()
        {
            return "MySQL";
        }
        protected override void DoDelete()
        {
            //code 
            Console.WriteLine("Delete done in MySQL Database");
        }

        protected override void DoInsert()
        {
            //code 
            Console.WriteLine("Insert done in MySQL Database");
        }

        protected override void DoUpdate()
        {
            //code 
            Console.WriteLine("Update done in MySQL Database");
        }
    }
    public class Logger
    {
        //object pooling
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
