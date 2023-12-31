﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.Entities.CategoriaPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<string>("NombreCategoria")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar")
                        .HasColumnName("NombreCategoria");

                    b.HasKey("Id");

                    b.ToTable("categoriaPersona", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<int>("IdDepartamentoFk")
                        .HasColumnType("int");

                    b.Property<string>("NombreCiudad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("nombreCiudad");

                    b.HasKey("Id");

                    b.HasIndex("IdDepartamentoFk");

                    b.ToTable("ciudad", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.ContactoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar")
                        .HasColumnName("descripcion");

                    b.Property<int>("IdPersonaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoContactoFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Descripcion")
                        .IsUnique();

                    b.HasIndex("IdPersonaFk");

                    b.HasIndex("IdTipoContactoFk");

                    b.ToTable("contactoPersona", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Contrato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaContrato")
                        .HasColumnType("date")
                        .HasColumnName("fechaContrato");

                    b.Property<DateOnly>("FechaFin")
                        .HasColumnType("date")
                        .HasColumnName("fechaFin");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpleadoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdEstadoFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdClienteFk");

                    b.HasIndex("IdEmpleadoFk");

                    b.HasIndex("IdEstadoFk");

                    b.ToTable("contrato", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<int>("IdPaisFk")
                        .HasColumnType("int");

                    b.Property<string>("NombreDepartamento")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("nombreDepartamento");

                    b.HasKey("Id");

                    b.HasIndex("IdPaisFk");

                    b.ToTable("departamento", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.DireccionPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar")
                        .HasColumnName("direccion");

                    b.Property<int>("IdPersonaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoDireccionFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPersonaFk");

                    b.HasIndex("IdTipoDireccionFk");

                    b.ToTable("direccionPersona", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar")
                        .HasColumnName("Descripcion");

                    b.HasKey("Id");

                    b.ToTable("estado", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<string>("NombrePais")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("nombrePais");

                    b.HasKey("Id");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaRegistro")
                        .HasColumnType("date")
                        .HasColumnName("fechaRegistro");

                    b.Property<int>("IdCategoriaPersonaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdCiudadFk")
                        .HasColumnType("int");

                    b.Property<string>("IdPersona")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("idPersona");

                    b.Property<int>("IdTipoPersonaFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.HasIndex("IdCategoriaPersonaFk");

                    b.HasIndex("IdCiudadFk");

                    b.HasIndex("IdPersona")
                        .IsUnique();

                    b.HasIndex("IdTipoPersonaFk");

                    b.ToTable("persona", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Programacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<int>("IdContratoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpleadoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTurnoFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdContratoFk");

                    b.HasIndex("IdEmpleadoFk");

                    b.HasIndex("IdTurnoFk");

                    b.ToTable("programacion", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("RefreshToken", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar")
                        .HasColumnName("rolName");

                    b.HasKey("Id");

                    b.ToTable("rol", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.RolUsuario", b =>
                {
                    b.Property<int>("IdUsuarioFk")
                        .HasColumnType("int");

                    b.Property<int>("IdRolFk")
                        .HasColumnType("int");

                    b.HasKey("IdUsuarioFk", "IdRolFk");

                    b.HasIndex("IdRolFk");

                    b.ToTable("rolUsuario", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.TipoContacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar")
                        .HasColumnName("Descripcion");

                    b.HasKey("Id");

                    b.ToTable("tipoContacto", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.TipoDireccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar")
                        .HasColumnName("Descripcion");

                    b.HasKey("Id");

                    b.ToTable("tipoDireccion", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.TipoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar")
                        .HasColumnName("Descripcion");

                    b.HasKey("Id");

                    b.ToTable("tipoPersona", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Turno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<TimeOnly>("HoraTurnoFin")
                        .HasColumnType("time")
                        .HasColumnName("horaTurnoFin");

                    b.Property<TimeOnly>("HoraTurnoInicio")
                        .HasColumnType("time")
                        .HasColumnName("horaTurnoInicio");

                    b.Property<string>("NombreTurno")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("nombreTurno");

                    b.HasKey("Id");

                    b.ToTable("turno", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar")
                        .HasColumnName("contraseña");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar")
                        .HasColumnName("correoElectronico");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("usuario", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Ciudad", b =>
                {
                    b.HasOne("Dominio.Entities.Departamento", "Departamento")
                        .WithMany("Ciudades")
                        .HasForeignKey("IdDepartamentoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("Dominio.Entities.ContactoPersona", b =>
                {
                    b.HasOne("Dominio.Entities.Persona", "Persona")
                        .WithMany("ContactoPersonas")
                        .HasForeignKey("IdPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.TipoContacto", "TipoContacto")
                        .WithMany("ContactoPersonas")
                        .HasForeignKey("IdTipoContactoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");

                    b.Navigation("TipoContacto");
                });

            modelBuilder.Entity("Dominio.Entities.Contrato", b =>
                {
                    b.HasOne("Dominio.Entities.Persona", "Cliente")
                        .WithMany("ContratosClientes")
                        .HasForeignKey("IdClienteFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Persona", "Empleado")
                        .WithMany("ContratosEmpleados")
                        .HasForeignKey("IdEmpleadoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Estado", "Estado")
                        .WithMany("Contratos")
                        .HasForeignKey("IdEstadoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Empleado");

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("Dominio.Entities.Departamento", b =>
                {
                    b.HasOne("Dominio.Entities.Pais", "Pais")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPaisFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("Dominio.Entities.DireccionPersona", b =>
                {
                    b.HasOne("Dominio.Entities.Persona", "Persona")
                        .WithMany("DireccionPersonas")
                        .HasForeignKey("IdPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.TipoDireccion", "TipoDireccion")
                        .WithMany("DireccionPersonas")
                        .HasForeignKey("IdTipoDireccionFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");

                    b.Navigation("TipoDireccion");
                });

            modelBuilder.Entity("Dominio.Entities.Persona", b =>
                {
                    b.HasOne("Dominio.Entities.CategoriaPersona", "CategoriaPersona")
                        .WithMany("Personas")
                        .HasForeignKey("IdCategoriaPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Ciudad", "Ciudad")
                        .WithMany("Personas")
                        .HasForeignKey("IdCiudadFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.TipoPersona", "TipoPersona")
                        .WithMany("Personas")
                        .HasForeignKey("IdTipoPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoriaPersona");

                    b.Navigation("Ciudad");

                    b.Navigation("TipoPersona");
                });

            modelBuilder.Entity("Dominio.Entities.Programacion", b =>
                {
                    b.HasOne("Dominio.Entities.Contrato", "Contrato")
                        .WithMany("Programaciones")
                        .HasForeignKey("IdContratoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Persona", "Empleado")
                        .WithMany("Programaciones")
                        .HasForeignKey("IdEmpleadoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Turno", "Turno")
                        .WithMany("Programaciones")
                        .HasForeignKey("IdTurnoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contrato");

                    b.Navigation("Empleado");

                    b.Navigation("Turno");
                });

            modelBuilder.Entity("Dominio.Entities.RefreshToken", b =>
                {
                    b.HasOne("Dominio.Entities.Usuario", "Usuario")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Dominio.Entities.RolUsuario", b =>
                {
                    b.HasOne("Dominio.Entities.Rol", "Rol")
                        .WithMany("RolUsuarios")
                        .HasForeignKey("IdRolFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Usuario", "Usuario")
                        .WithMany("RolUsuarios")
                        .HasForeignKey("IdUsuarioFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Dominio.Entities.CategoriaPersona", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Entities.Ciudad", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Entities.Contrato", b =>
                {
                    b.Navigation("Programaciones");
                });

            modelBuilder.Entity("Dominio.Entities.Departamento", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("Dominio.Entities.Estado", b =>
                {
                    b.Navigation("Contratos");
                });

            modelBuilder.Entity("Dominio.Entities.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Dominio.Entities.Persona", b =>
                {
                    b.Navigation("ContactoPersonas");

                    b.Navigation("ContratosClientes");

                    b.Navigation("ContratosEmpleados");

                    b.Navigation("DireccionPersonas");

                    b.Navigation("Programaciones");
                });

            modelBuilder.Entity("Dominio.Entities.Rol", b =>
                {
                    b.Navigation("RolUsuarios");
                });

            modelBuilder.Entity("Dominio.Entities.TipoContacto", b =>
                {
                    b.Navigation("ContactoPersonas");
                });

            modelBuilder.Entity("Dominio.Entities.TipoDireccion", b =>
                {
                    b.Navigation("DireccionPersonas");
                });

            modelBuilder.Entity("Dominio.Entities.TipoPersona", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Entities.Turno", b =>
                {
                    b.Navigation("Programaciones");
                });

            modelBuilder.Entity("Dominio.Entities.Usuario", b =>
                {
                    b.Navigation("RefreshTokens");

                    b.Navigation("RolUsuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
