using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class TurnoConfiguration : IEntityTypeConfiguration<Turno>
{
    public void Configure(EntityTypeBuilder<Turno> builder)
    {

        builder.ToTable("turno");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
        .HasColumnType("int")
        .HasMaxLength(11)
        .IsRequired();

        builder.Property(p => p.NombreTurno)
        .HasColumnName("nombreTurno")
        .HasColumnType("varchar")
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p => p.HoraTurnoInicio)
        .HasColumnName("horaTurnoInicio")
        .HasColumnType("time")
        .IsRequired();

        builder.Property(p => p.HoraTurnoFin)
        .HasColumnName("horaTurnoFin")
        .HasColumnType("time")
        .IsRequired();
    }
}