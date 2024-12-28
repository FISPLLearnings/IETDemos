using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _0004DemoMVC.Models
{
    [Table("Emp")]
    public class Emp
    {
        [Column("No", TypeName = "int")]
        [Key]
        public int No { get; set; }
        
        [Column("Name", TypeName = "varchar")]
        [StringLength(50)]
        public string Name { get; set; }
        
        [Column("Address", TypeName = "varchar")]
        [StringLength(50)]
        public string Address { get; set; }
    }

    [Table("Trainer")]
    public class Trainer
    {
        [Column("TrainerID", TypeName = "int")]
        [Key]
        public int TrainerID { get; set; }

        [Column("TrainerName", TypeName = "varchar")]
        [StringLength(50)]
        public string TrainerName { get; set; }

        public List<Subject> Subjects { get; set; }
    }


    [Table("Subject")]
    public class Subject
    {
        [Column("SubjectID", TypeName = "int")]
        [Key]
        public int SubjectID { get; set; }

        [Column("SubjectTitle", TypeName = "varchar")]
        [StringLength(50)]
        public string SubjectTitle { get; set; }

        public List<Trainer> Trainers { get; set; }

    }

    public class MyDB:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Emp> Emps { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=MyDB;Integrated Security=True;");
        }
    }

    [Table("Customer")]
    public class Customer
    {
        [Column("CID", TypeName = "int")]
        [Key]
        public int CNo { get; set; }

        [Column("CName", TypeName = "varchar")]
        [StringLength(50)]
        public string CName { get; set; }

    }
}
