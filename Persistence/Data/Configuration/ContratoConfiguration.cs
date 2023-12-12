using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class ContratoConfiguration : IEntityTypeConfiguration<Contrato>
{
    public void Configure(EntityTypeBuilder<Contrato> builder)
    {

        builder.ToTable("contrato");
        builder.HasKey(p => p.Id);
        
        builder.Property(p => p.Id)
        .HasColumnType("int")
        .HasMaxLength(11)
        .IsRequired();
        
        builder.Property(p => p.FechaContrato)
        .HasColumnName("fechaContrato")
        .HasColumnType("date")
        .IsRequired();

        builder.Property(p => p.FechaFin)
        .HasColumnName("fechaFin")
        .HasColumnType("date")
        .IsRequired();

        builder.HasOne(d => d.Cliente)
        .WithMany(d => d.ContratosClientes)
        .HasForeignKey(d => d.IdClienteFk);

        builder.HasOne(d => d.Empleado)
        .WithMany(d => d.ContratosEmpleados)
        .HasForeignKey(d => d.IdEmpleadoFk);

        builder.HasOne(d => d.Estado)
        .WithMany(d => d.Contratos)
        .HasForeignKey(d => d.IdEstadoFk);
    }
}