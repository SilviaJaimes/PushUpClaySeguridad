using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class DireccionPersonaConfiguration : IEntityTypeConfiguration<DireccionPersona>
{
    public void Configure(EntityTypeBuilder<DireccionPersona> builder)
    {

        builder.ToTable("direccionPersona");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .HasColumnType("int")
        .HasMaxLength(11)
        .IsRequired();

        builder.Property(p => p.Direccion)
        .HasColumnName("direccion")
        .HasColumnType("varchar")
        .HasMaxLength(250)
        .IsRequired();

        builder.HasOne(d => d.Persona)
        .WithMany(d => d.DireccionPersonas)
        .HasForeignKey(d => d.IdPersonaFk);

        builder.HasOne(d => d.TipoDireccion)
        .WithMany(d => d.DireccionPersonas)
        .HasForeignKey(d => d.IdTipoDireccionFk);
    }
}