using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {

        builder.ToTable("departamento");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .HasColumnType("int")
        .HasMaxLength(11)
        .IsRequired();

        builder.Property(c => c.NombreDepartamento)
        .HasColumnName("nombreDepartamento")
        .HasColumnType("varchar")
        .HasMaxLength(100)
        .IsRequired();

        builder.HasOne(d => d.Pais)
        .WithMany(d => d.Departamentos)
        .HasForeignKey(d => d.IdPaisFk);
    }
}