using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;


namespace WebApplication1.Context;


public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    { }

    public DbSet<Login> Logins { get; set; }
    public DbSet<Bebidas> Bebidas { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Lanches> Lanches { get; set; } 
    public DbSet<PedidoBebida> PedidosBebidas { get; set; }
    public DbSet<PedidoLanche> PedidosLanches { get; set; } 
    public DbSet<Venda> Vendas { get; set; }
    public DbSet<Entrega> Entregas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PedidoLanche>()
            .HasNoKey();
        modelBuilder.Entity<PedidoBebida>()
            .HasNoKey();

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=BaldeDeLixo.db;Cache=Shared");
    }
}
