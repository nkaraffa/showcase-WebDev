using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;   //Enables connection to DB

namespace EmpManagement.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            :base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Eid =101,
                    Name = "Deepali",
                    Email = "deepali@gmail.com",
                    Department = Dept.HR
                },
                new Employee
                {
                    Eid = 102,
                    Name = "Jenny",
                    Email = "jenny@gmail.com",
                    Department = Dept.HR
                }
                );
        }
    }
}
