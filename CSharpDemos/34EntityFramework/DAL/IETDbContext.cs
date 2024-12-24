using _34EntityFramework.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace _34EntityFramework.DAL
{
    public class IETDbContext :DbContext
    {
        public DbSet<Employee> employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //a Service for - To read appsettings.json config file
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfiguration config= builder.Build();
            string connectionString = config.GetConnectionString("conStr");

            //Databse Provider Service Register
            optionsBuilder.UseSqlServer(connectionString);
        }

        public Employee GetEmployeesById(int id)
        {
            var idParam = new SqlParameter("@Id",id);
            #pragma warning disable CS8603
            return employees.FromSqlRaw("EXEC GetEmployeesById @Id", idParam)
                    .AsEnumerable().FirstOrDefault();
            #pragma warning restore CS8603
        }
        public List<Employee> GetEmployeesByAddressStartsWith(string StartLetter)
        {
            var startLetterParam = new SqlParameter("@StartLetter", StartLetter);
            return employees.FromSqlRaw("EXEC GetEmployeesByAddressStartsWith @StartLetter",startLetterParam)
                            .AsEnumerable().ToList();
        }
    }
}
