using _34EntityFramework.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace _34EntityFramework.DAL
{
    public class IETDbContext :DbContext
    {
        public DbSet<Employee> employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfiguration config= builder.Build();
            string connectionString = config.GetConnectionString("conStr");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
