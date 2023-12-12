using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class TipoDireccionConfiguration : IEntityTypeConfiguration<TipoDireccion>
{
    public void Configure(EntityTypeBuilder<TipoDireccion> builder)
    {

        builder.ToTable("tipoDireccion");
        builder.HasKey(p => p.Id);
        
        builder.Property(p => p.Id)
        .HasColumnType("int")
        .HasMaxLength(11)
        .IsRequired();
        
        builder.Property(p => p.Descripcion)
        .HasColumnName("Descripcion")
        .HasColumnType("varchar")
        .HasMaxLength(250)
        .IsRequired();
    }
}