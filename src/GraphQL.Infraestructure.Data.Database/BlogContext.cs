using GraphQL.Infraestructure.Data.Database.Entity.Campany;
using GraphQL.Infraestructure.Data.Database.Entity.Department;
using GraphQL.Infraestructure.Data.Database.Entity.Employee;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Infraestructure.Data.Database
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> opcoes) : base(opcoes)
        {
        }

        public DbSet<CompanyEntity> Companies { get; set; }
        public DbSet<DepartmentEntity> Departments { get; set; }
        public DbSet<EmployeeEntity> Employees { get; set; }
    }
}
