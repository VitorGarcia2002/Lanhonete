using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;


namespace WebApplication1.Context

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Login> Logins { get; set; }
    }
        


}
