using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Configuration;

public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK__Producto__3214EC07C7450B06");

            builder.ToTable("Producto");

            builder.HasIndex(e => e.CategoriaId, "IX_Producto_CategoriaId");

            builder.HasIndex(e => e.MarcaId, "IX_Producto_MarcaId");

            builder.Property(e => e.CategoriaId).HasDefaultValueSql("('0')");
            builder.Property(e => e.FechaCreacion).HasColumnType("datetime");
            builder.Property(e => e.MarcaId).HasDefaultValueSql("('0')");
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            builder.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

            builder.HasOne(d => d.Categoria).WithMany(p => p.Productos).HasForeignKey(d => d.CategoriaId);

            builder.HasOne(d => d.Marca).WithMany(p => p.Productos).HasForeignKey(d => d.MarcaId);
    }
}