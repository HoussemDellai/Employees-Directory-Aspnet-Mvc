using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDirectoryDemo.Models
{
    public class Employee
    {

        public int Id { get; set; }

        public string Fullname { get; set; }

        public Department Department { get; set; }

        public int DepartmentId { get; set; }


        public int CIN { get; set; }
    }
}
