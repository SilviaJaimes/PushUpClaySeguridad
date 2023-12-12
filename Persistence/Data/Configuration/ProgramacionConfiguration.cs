using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class ProgramacionConfiguration : IEntityTypeConfiguration<Programacion>
{
    public void Configure(EntityTypeBuilder<Programacion> builder)
    {

        builder.ToTable("programacion");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .HasColumnType("int")
        .HasMaxLength(11)
        .IsRequired();

        builder.HasOne(d => d.Contrato)
        .WithMany(d => d.Programaciones)
        .HasForeignKey(d => d.IdContratoFk);

        builder.HasOne(d => d.Turno)
        .WithMany(d => d.Programaciones)
        .HasForeignKey(d => d.IdTurnoFk);

        builder.HasOne(d => d.Empleado)
        .WithMany(d => d.Programaciones)
        .HasForeignKey(d => d.IdEmpleadoFk);
    }
}