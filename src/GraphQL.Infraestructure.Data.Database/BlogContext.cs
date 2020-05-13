using GraphQL.Infraestructure.Data.Database.Entity;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Infraestructure.Data.Database
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> opcoes) : base(opcoes)
        {
        }

        public DbSet<Company> Companies { get; set; }
    }
}
