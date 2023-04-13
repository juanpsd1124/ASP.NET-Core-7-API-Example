using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraesctucture.Data
{
    public class TiendaContext : DbContext
    {
        public TiendaContext(DbContextOptions <TiendaContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos {get;set;}

        public DbSet<Marca> Marcas { get; set; } 

        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}