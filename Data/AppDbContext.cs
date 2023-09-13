using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using BookStore.Models;
namespace BookStore.Data;

public class AppDbContext: DbContext
{
    protected readonly IConfiguration Configuration;
    
    public AppDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // connect to postgres database using connection string from appsettings.json
        optionsBuilder.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
    }
    
    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Author> Authors { get; set; } = null!;
    
}