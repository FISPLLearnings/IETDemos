using _31ConnectedArchitetureDb.DAL;
using _31ConnectedArchitetureDb.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace _31ConnectedArchitetureDb
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region CRUD with Console.WriteLine
            #region select Records
            //SqlConnection con = new SqlConnection(conStr);
            //string query = "select * from Emp";
            //SqlCommand cmd = new SqlCommand(query, con);
            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            ////Reading one row from database at a time
            ////giving us collection of columns values
            //while (reader.Read())
            //{
            //    int id = Convert.ToInt32(reader[0]);
            //    string? name = reader[1].ToString();
            //    string? address = reader[2].ToString();
            //    Console.WriteLine($"Id: {id}, NAme:{name}, Address: {address}");
            //}
            //con.Close();
            #endregion

            #region Insert Records 
            //SqlConnection con = new SqlConnection(conStr);
            //Console.WriteLine("Enter name :");
            //string? nm = Console.ReadLine();
            //Console.WriteLine("Enter name :");
            //string? add = Console.ReadLine();

            //string query = $"insert into Emp values('{nm}','{add}')";
            //SqlCommand cmd = new SqlCommand(query, con);
            //con.Open();
            //int noOfRowsAffected = cmd.ExecuteNonQuery();
            //con.Close(); 
            //if (noOfRowsAffected > 0)
            //{
            //    Console.WriteLine("Record inserted into EMp successfully!");
            //}

            #endregion

            #region Update Records 
            //SqlConnection con = new SqlConnection(conStr);
            //Console.WriteLine("Enter name :");
            //string? nm = Console.ReadLine();
            //Console.WriteLine("Enter name :");
            //string? add = Console.ReadLine();

            //string query = $"update Emp set Name='{nm}', Address='{add}' where Id= 5";
            //SqlCommand cmd = new SqlCommand(query, con);
            //con.Open();
            //int noOfRowsAffected = cmd.ExecuteNonQuery();
            //con.Close();
            //if (noOfRowsAffected > 0)
            //{
            //    Console.WriteLine("Record updated into EMp successfully!");
            //}

            #endregion

            #region Delete Records 
            //SqlConnection con = new SqlConnection(conStr);
            //Console.WriteLine("Enter Id :");
            //int?id = Convert.ToInt32(Console.ReadLine());

            //string query = $"Delete from Emp where Id = {id}";
            //SqlCommand cmd = new SqlCommand(query, con);
            //con.Open();
            //int noOfRowsAffected = cmd.ExecuteNonQuery();
            //con.Close();
            //if (noOfRowsAffected > 0)
            //{
            //    Console.WriteLine("Record deleted into EMp successfully!");
            //}
            #endregion
            #endregion

            //Buissness Presentation  - UI
            while (true)
            {
                IETDbContext dbContext = new IETDbContext();
                int noOFRowsAfftected = 0;
                Console.WriteLine("Enter DB Operation Choice: 1. Select, 2.Insert, 3.Update, 4.Delete");
                int opChoice = Convert.ToInt32(Console.ReadLine());
                switch(opChoice)
                {
                    case 1:
                        List<Emp> allEmployees = dbContext.SelectRecords();
                        foreach (var emp in allEmployees)
                        {
                            Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Address: {emp.Address}");
                        }
                        break;
                    case 2:
                        Emp empToBeInserted = new Emp();
                        Console.WriteLine("Enter NAme ");
                        empToBeInserted.Name = Console.ReadLine();
                        Console.WriteLine("Enter Address ");
                        empToBeInserted.Address = Console.ReadLine();
                        noOFRowsAfftected  = dbContext.InsertRecords(empToBeInserted);
                        break;
                        case 3:
                        Emp empToBeUpdated = new Emp();
                        Console.WriteLine("Enter Id:");
                        empToBeUpdated.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name:");
                        empToBeUpdated.Name = Console.ReadLine();
                        Console.WriteLine("Enter Address:");
                        empToBeUpdated.Address = Console.ReadLine();
                        noOFRowsAfftected = dbContext.UpdateRecords(empToBeUpdated);
                        if(noOFRowsAfftected> 0)
                        {
                            Console.WriteLine("Records updated in DB successfully");
                        }
                        break;
                        case 4:
                        Console.WriteLine("Enter Id:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        noOFRowsAfftected = dbContext.DeleteRecords(id);
                        if (noOFRowsAfftected > 0)
                        {
                            Console.WriteLine("Records deleted from DB successfully");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

                Console.WriteLine("Do you wish to continue> y/n");
                string ynChoice = Console.ReadLine();
                if(ynChoice == "n")
                {
                    break;
                }
            }
        }
    }
}
