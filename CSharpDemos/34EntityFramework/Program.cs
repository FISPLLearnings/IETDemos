using _34EntityFramework.DAL;
using _34EntityFramework.Model;

namespace _34EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IETDbContext dbContext = new IETDbContext();
            while (true)
            {
                Console.WriteLine("Enter operation choice 1. Select, 2. Insert, 3.Update, 4.Delete" +
                    " 5. Get Employee by Id using SP, 6. Get All Employess based on Address start Letter");
                int opChoice = Convert.ToInt32(Console.ReadLine());
                switch (opChoice)
                {
                    case 1:
                        var allEmployees = dbContext.employees.ToList();
                        foreach (var emp in allEmployees)
                        {
                            Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Address: {emp.Address}");
                        }
                        break;
                    case 2:
                        Employee empRecordToBeInserted = new Employee();
                        Console.WriteLine("Enter Name:");
                        empRecordToBeInserted.Name = Console.ReadLine();
                        Console.WriteLine("Enter Address:");
                        empRecordToBeInserted.Address = Console.ReadLine();

                        dbContext.employees.Add(empRecordToBeInserted);

                        //it observes collection and generates queries like - insert, update,delete
                        dbContext.SaveChanges(); 
                        break;
                    case 3:
                        Console.WriteLine("Enter Id");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Employee empRecordToBeUpdated = dbContext.employees.Find(id);

                        Console.WriteLine("Enter Name:");
                        empRecordToBeUpdated.Name = Console.ReadLine();
                        Console.WriteLine("Enter Address:");
                        empRecordToBeUpdated.Address = Console.ReadLine();

                        dbContext.SaveChanges();
                        break;
                    case 4:
                        Console.WriteLine("Enter Id");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        Employee empToBeDeleted = dbContext.employees.Find(id1);
                        dbContext.employees.Remove(empToBeDeleted);
                        dbContext.SaveChanges();
                        break;
                    case 5:
                        Console.WriteLine("Enter Id of Employee To Be Searched");
                        int idToBeSearched = Convert.ToInt32(Console.ReadLine());
                        Employee empById = dbContext.GetEmployeesById(idToBeSearched);
                        Console.WriteLine($"Id: {empById.Id}, Name: {empById.Name}, Address: {empById.Address}");
                        break;
                    case 6:
                        Console.WriteLine("Enter first letter of Address for Employees to Be searched");
                        string? cityStartLetter = Console.ReadLine().ToUpper();
                        var emps = dbContext.GetEmployeesByAddressStartsWith(cityStartLetter);
                        foreach (var employee in emps)
                        {
                            Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Address: {employee.Address}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Choice..");
                        break;
                }

                Console.WriteLine("Do you want to continue? y/n");
                string? ynChoice = Console.ReadLine();
                if (ynChoice == "n")
                {
                    break;
                }
            }
        }
    }
}
