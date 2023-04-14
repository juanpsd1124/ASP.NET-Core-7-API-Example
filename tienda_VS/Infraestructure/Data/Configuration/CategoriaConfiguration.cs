
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data.Configuration;
public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
{

    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        builder.ToTable("Categoria");

        builder.Property(p => p.Id)
            .IsRequired();

        builder.Property(p => p.Nombre)
            .IsRequired()
            .HasMaxLength(100);

    }

}