using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraesctucture.Data.Configuration;

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
