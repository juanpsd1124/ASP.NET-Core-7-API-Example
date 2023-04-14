using Microsoft.EntityFrameworkCore;
using Core.Entities;
using System.Reflection;

namespace Infraestructure.Data;

public class TiendaContext : DbContext
{
    public TiendaContext(DbContextOptions options) : base(options)
    {
 
    }

    public DbSet<Producto> Productos { get; set; }
    public DbSet<Marca> Marcas { get; set; }
    public DbSet<Categoria> Categorias { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}