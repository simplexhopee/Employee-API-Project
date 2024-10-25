// EmployeeService/Data/EmployeeContext.cs
using Microsoft.EntityFrameworkCore;
using EmployeeService.Models;

namespace EmployeeService.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
