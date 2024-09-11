﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebGrilla.Data;

#nullable disable

namespace WebGrilla.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240906020619_Primera")]
    partial class Primera
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebGrilla.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("WebGrilla.Models.EquipoDesarrollo", b =>
                {
                    b.Property<int>("IdEquipoDesarrollo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEquipoDesarrollo"), 1L, 1);

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("Nombre")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("IdEquipoDesarrollo");

                    b.HasIndex("IdCliente");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("WebGrilla.Models.Recurso", b =>
                {
                    b.Property<int>("IdRecurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRecurso"), 1L, 1);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdEquipoDesarrollo")
                        .HasColumnType("int");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("NumeroDocumento")
                        .HasColumnType("decimal(17,0)");

                    b.Property<int>("TipoDocumento")
                        .HasColumnType("int");

                    b.HasKey("IdRecurso");

                    b.HasIndex("IdEquipoDesarrollo");

                    b.HasIndex("IdRol");

                    b.ToTable("Recursos");
                });

            modelBuilder.Entity("WebGrilla.Models.Rol", b =>
                {
                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRol"), 1L, 1);

                    b.Property<int>("Nombre")
                        .HasColumnType("int");

                    b.HasKey("IdRol");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WebGrilla.Models.EquipoDesarrollo", b =>
                {
                    b.HasOne("WebGrilla.Models.Cliente", "Cliente")
                        .WithMany("Equipos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("WebGrilla.Models.Recurso", b =>
                {
                    b.HasOne("WebGrilla.Models.EquipoDesarrollo", "EquipoDesarrollo")
                        .WithMany("Recursos")
                        .HasForeignKey("IdEquipoDesarrollo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebGrilla.Models.Rol", "Rol")
                        .WithMany("Recursos")
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EquipoDesarrollo");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("WebGrilla.Models.Cliente", b =>
                {
                    b.Navigation("Equipos");
                });

            modelBuilder.Entity("WebGrilla.Models.EquipoDesarrollo", b =>
                {
                    b.Navigation("Recursos");
                });

            modelBuilder.Entity("WebGrilla.Models.Rol", b =>
                {
                    b.Navigation("Recursos");
                });
#pragma warning restore 612, 618
        }
    }
}
