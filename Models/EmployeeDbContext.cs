using Microsoft.EntityFrameworkCore;

namespace WebApplication12.Models
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext()
        {
        }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Department> Departments{ get; set; } = null!;
    }
}
