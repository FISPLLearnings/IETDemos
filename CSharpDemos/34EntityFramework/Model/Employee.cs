using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _34EntityFramework.Model
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [Column("EId",TypeName ="int")]
        public  int Id { get; set; }

        [Column("EName",TypeName ="varchar(50)")]
        public string Name { get; set; }

        [Column("EAddress", TypeName = "varchar(50)")]
        public string Address { get; set; }
    }
}
