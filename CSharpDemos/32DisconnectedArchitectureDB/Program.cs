using Microsoft.Data.SqlClient;
using System.Data;

namespace _32DisconnectedArchitectureDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=IETDb;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            string selectQueryText = "select * from Emp";
            SqlDataAdapter da = new SqlDataAdapter(selectQueryText, con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            da.Fill(ds);
            //DataColumn col1 = new DataColumn("Id",typeof(int));
            //DataColumn col2 = new DataColumn("Name",typeof(string));
            //DataColumn col3 = new DataColumn("Address",typeof(string));
            //DataRow row = new DataRow();
            
            foreach(DataRow row in dt.Rows)
            {
                Console.WriteLine($"Id: {row["Id"]}, Name: {row["Name"]}, Address: {row["Address"]}");
            }
        }
    }
}
