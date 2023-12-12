using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {

        builder.ToTable("persona");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .HasColumnType("int")
        .HasMaxLength(11)
        .IsRequired();

        builder.Property(p => p.IdPersona)
        .HasColumnName("idPersona")
        .HasColumnType("varchar")
        .HasMaxLength(50)
        .IsRequired();

        builder.HasIndex(p => p.IdPersona)
        .IsUnique();

        builder.Property(p => p.Nombre)
        .HasColumnName("nombre")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.FechaRegistro)
        .HasColumnName("fechaRegistro")
        .HasColumnType("date")
        .IsRequired();

        builder.HasOne(d => d.TipoPersona)
        .WithMany(d => d.Personas)
        .HasForeignKey(d => d.IdTipoPersonaFk);

        builder.HasOne(d => d.CategoriaPersona)
        .WithMany(d => d.Personas)
        .HasForeignKey(d => d.IdCategoriaPersonaFk);

        builder.HasOne(d => d.Ciudad)
        .WithMany(d => d.Personas)
        .HasForeignKey(d => d.IdCiudadFk);
    }
}