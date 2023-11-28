using Microsoft.EntityFrameworkCore;

namespace WebApiApp.Models
{
    public class CompanyEntity:DbContext
    {
        public DbSet<Employee>   Employees { get; set; }
        public DbSet<Department> Department { get; set; }
        public CompanyEntity()
        {

        }
        public CompanyEntity(DbContextOptions options):base(options)
        {

        }

    }
}
