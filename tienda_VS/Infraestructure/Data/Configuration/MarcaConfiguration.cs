using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data.Configuration;
public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
{

    public void Configure(EntityTypeBuilder<Marca> builder)
    {
        builder.ToTable("Marca");

        builder.Property(p => p.Id)
            .IsRequired();

        builder.Property(p => p.Nombre)
            .IsRequired()
            .HasMaxLength(100);

    }

}
