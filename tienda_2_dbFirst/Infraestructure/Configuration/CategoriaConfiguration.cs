using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Configuration;

public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        builder.ToTable("Categoria");

        builder.HasKey(e => e.Id).HasName("PK__Categori__3214EC07132E4310");

        builder.Property(e => e.Nombre)
            .HasMaxLength(100)
            .IsUnicode(false);
    }
}
