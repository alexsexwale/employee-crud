using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int PersonId { get; set; }
        public string EmployeeNum { get; set; }
        public DateTime EmployeeDate { get; set; }
        public DateTime TerminatedDate { get; set; }
    }
}
