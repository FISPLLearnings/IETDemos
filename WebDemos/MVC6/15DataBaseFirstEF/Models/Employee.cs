using System;
using System.Collections.Generic;

namespace _15DataBaseFirstEF.Models
{
    public partial class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; } = null!;
        public string Eaddress { get; set; } = null!;
        public int Esalary { get; set; }
    }
}
