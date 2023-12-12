using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class ContactoPersonaConfiguration : IEntityTypeConfiguration<ContactoPersona>
{
    public void Configure(EntityTypeBuilder<ContactoPersona> builder)
    {

        builder.ToTable("contactoPersona");
        builder.HasKey(p => p.Id);
        
        builder.Property(p => p.Id)
        .HasColumnType("int")
        .HasMaxLength(11)
        .IsRequired();
        
        builder.Property(p => p.Descripcion)
        .HasColumnName("descripcion")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder.HasIndex(p => p.Descripcion)
        .IsUnique();

        builder.HasOne(d => d.TipoContacto)
        .WithMany(d => d.ContactoPersonas)
        .HasForeignKey(d => d.IdTipoContactoFk);

        builder.HasOne(d => d.Persona)
        .WithMany(d => d.ContactoPersonas)
        .HasForeignKey(d => d.IdPersonaFk);
    }
}