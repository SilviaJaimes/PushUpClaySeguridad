using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
{
    public void Configure(EntityTypeBuilder<Ciudad> builder)
    {

        builder.ToTable("ciudad");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .HasColumnType("int")
        .HasMaxLength(11)
        .IsRequired();

        builder.Property(c => c.NombreCiudad)
        .HasColumnName("nombreCiudad")
        .HasColumnType("varchar")
        .HasMaxLength(100)
        .IsRequired();

        builder.HasOne(d => d.Departamento)
        .WithMany(d => d.Ciudades)
        .HasForeignKey(d => d.IdDepartamentoFk);
    }
}