using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;


namespace WebApplication1.Context;


public class DataContext : DbContext
{
    public DbSet<Login> Logins { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=BaldeDeLixo.db;Cache=Shared");
    }
}
