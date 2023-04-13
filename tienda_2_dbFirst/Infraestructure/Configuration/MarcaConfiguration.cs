using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Configuration;

public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
{
    public void Configure(EntityTypeBuilder<Marca> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK__Marca__3214EC076D061926");

        builder.ToTable("Marca");

        builder.Property(e => e.Nombre)
            .HasMaxLength(100)
            .IsUnicode(false);
    }
}