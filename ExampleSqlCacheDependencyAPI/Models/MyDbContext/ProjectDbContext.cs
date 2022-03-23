using Microsoft.EntityFrameworkCore;

namespace ExampleSqlCacheDependencyAPI.Models.MyDbContext;
public class ProjectDbContext : DbContext
{
    public DbSet<Telephone> Telephones { get; set; }
    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-257PM20\\SQLEXPRESS;Database=SQLCacheDependency;Trusted_Connection=true;");
        }
    }
}