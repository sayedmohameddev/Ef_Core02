using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Session02_Demo.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }

        [ForeignKey("Manager")]
        public int EmpId { get; set; } // Forign key

        public Employee Manager { get; set; } // Navigational property

        public List<Employee> Employees { get; set; } // Department has many employees 
    }
}
