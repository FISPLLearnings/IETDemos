using Microsoft.Data.SqlClient;
using System.Data;

namespace _33ConnectedWithDataset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=IETDb;Integrated Security=True";
            
            //Create DataTable along with Schema as Databse Table Emp
            DataSet ds =new DataSet();
            DataTable dt = new DataTable();
            DataColumn col1 = new DataColumn("Id",typeof(int));
            DataColumn col2 = new DataColumn("Name",typeof(string));
            DataColumn col3 = new DataColumn("Address",typeof(string));
            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.PrimaryKey = new DataColumn[] { col1};

            //Using COnnected Architecture  - fetch the records
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("select * from Emp", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //[[Id- PrimaryKey],[Name: string],[Address:string]]
                DataRow row = dt.NewRow(); 
                row["Id"] = Convert.ToInt32(reader["Id"]);
                row["Name"] = reader["Name"].ToString();
                row["Address"] = reader["Address"].ToString();
                dt.Rows.Add(row);
            }
            con.Close();
            ds.Tables.Add(dt);
            ds.WriteXml(@"D:\IETCDAC\Dec24\IETCsharpDemos\CSharpDemos\33ConnectedWithDataset\Data\EmpData.xml");
           // ds.WriteXmlSchema("Filepath");
        }
    }
}
