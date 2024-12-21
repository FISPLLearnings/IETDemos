using _31ConnectedArchitetureDb.Model;
using Microsoft.Data.SqlClient;

namespace _31ConnectedArchitetureDb.DAL
{
    //Buissness Logic
    public class IETDbContext
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=IETDb;Integrated Security=True";
        List<Emp> emps = new List<Emp>();
        public List<Emp> SelectRecords()
        {
            SqlConnection con = new SqlConnection(conStr);
            string selectQuery = "select * from Emp";
            SqlCommand cmd = new SqlCommand(selectQuery,con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                emps.Add(new Emp()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Address = reader["Address"].ToString()
                });
            }
            con.Close();
            return emps;
        }
        public int InsertRecords(Emp emp)
        {
            SqlConnection con = new SqlConnection(conStr);
            string insertQuery = $"insert into Emp values('{emp.Name}','{emp.Address}')";
            SqlCommand cmd = new SqlCommand(insertQuery,con);
            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsAffected;
        }
        public int UpdateRecords(Emp emp)
        {
            SqlConnection con = new SqlConnection(conStr);
            string insertQuery = $"update Emp set Name ='{emp.Name}', Address ='{emp.Address}' where Id={emp.Id}";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsAffected;
        }
        public int DeleteRecords(int id)
        {
            SqlConnection con = new SqlConnection(conStr);
            string insertQuery = $"delete from Emp where Id={id}";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsAffected;
        }
    }
}
