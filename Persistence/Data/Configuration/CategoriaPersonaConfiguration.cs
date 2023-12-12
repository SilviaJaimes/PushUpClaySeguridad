using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class CategoriaPersonaConfiguration : IEntityTypeConfiguration<CategoriaPersona>
{
    public void Configure(EntityTypeBuilder<CategoriaPersona> builder)
    {

        builder.ToTable("categoriaPersona");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .HasColumnType("int")
        .HasMaxLength(11)
        .IsRequired();

        builder.Property(cp => cp.NombreCategoria)
        .HasColumnName("NombreCategoria")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();
    }
}