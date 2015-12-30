using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace EmployeesDirectoryDemo.Models
{
    public class EmployeesContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EmployeesContext() : base("name=EmployeesContext")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<EmployeesContext>());
        }

        public DbSet<Employee> Employees
        {
            get; set;
        }

        public DbSet<Department> Departments
        {
            get; set;
        }
    }
}
