namespace _05OOPInterface
{
    internal class Program
    {
        static void Main(string[] args)
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
       
        public void Insert()
        {
            //code 
            Console.WriteLine("Insert done in SQL Server Database");
        }
        public void Update()
        {
            //code 
            Console.WriteLine("Update done in SQL Server Database");
        }
        public void Delete()
        {
            //code 
            Console.WriteLine("Delete done in SQL Server Database");
        }
    }
    public class Oracle : IDatabase
    {
        public void Insert()
        {
            //code 
            Console.WriteLine("Insert done in Oracle Database");
        }
        public void Update()
        {
            //code 
            Console.WriteLine("Update done in Oracle Database");
        }
        public void Delete()
        {
            //code 
            Console.WriteLine("Delete done in Oracle Database");
        }
    }
    public class MySQL : IDatabase
    {
        public void Delete()
        {
            //code 
            Console.WriteLine("Delete done in MySQL Database");
        }

        public void Insert()
        {
            //code 
            Console.WriteLine("Insert done in MySQL Database");
        }

        public void Update()
        {
            //code 
            Console.WriteLine("Update done in MySQL Database");
        }
    }
}
