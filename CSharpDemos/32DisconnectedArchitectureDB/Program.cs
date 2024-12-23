using Microsoft.Data.SqlClient;
using System.Data;

namespace _32DisconnectedArchitectureDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=IETDb;Integrated Security=True";
            
            #region Select Query using Disconnected Architecture
            //SqlConnection con = new SqlConnection(conStr);
            //string selectQueryText = "select * from Emp";
            //SqlDataAdapter da = new SqlDataAdapter(selectQueryText, con);
            //da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            //SqlCommandBuilder builder = new SqlCommandBuilder(da);

            //DataTable dt = new DataTable();
            //da.Fill(dt); //select query
            //             // DataSet ds = new DataSet();
            //             // ds.Tables.Add(dt);
            //             //da.Fill(ds);

            ////foreach(DataRow row in dt.Rows)
            ////{
            ////    Console.WriteLine($"Id: {row["Id"]}, Name: {row["Name"]}, Address: {row["Address"]}");
            ////} 
            #endregion

            #region Insert Query using Diconnected Architeture 
            //Console.WriteLine("Enter Name");
            //string nm = Console.ReadLine();
            //Console.WriteLine("Enter Name");
            //string add = Console.ReadLine();
            //DataRow row =  dt.NewRow();
            //row["Name"] = nm;
            //row["Address"] = add;

            //dt.Rows.Add(row);
            //da.Update(dt);
            #endregion

            #region Update query using Disconnected Architecture 
            //Console.WriteLine("Enter Id:");
            //int id = Convert.ToInt32(Console.ReadLine());
            //DataRow empToBeEdited = dt.Rows.Find(id);

            //Console.WriteLine("Enter Name ");
            //empToBeEdited["Name"] = Console.ReadLine();
            //Console.WriteLine("Enter Address ");
            //empToBeEdited["Address"] = Console.ReadLine();

            //da.Update(dt);
            #endregion

            #region Delete Query Using Disconnected Architecture 
            //Console.WriteLine("Enter Id:");
            //int id = Convert.ToInt32(Console.ReadLine());

            //DataRow? empToBeDeleted = dt.Rows.Find(id);

            ////dt.Rows.Remove(empToBeDeleted); 
            //empToBeDeleted.Delete();

            //da.Update(dt);
            #endregion
        }
    }
}
