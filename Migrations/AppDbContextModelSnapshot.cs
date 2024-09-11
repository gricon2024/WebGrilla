﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebGrilla.Data;

#nullable disable

namespace WebGrilla.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("WebGrilla.Models.ConocimientoRecurso", b =>
                {
                    b.Property<int>("IdConocimientoRecurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdConocimientoRecurso"), 1L, 1);

                    b.Property<int>("IdEvaluacion")
                        .HasColumnType("int");

                    b.Property<int>("IdGrilla")
                        .HasColumnType("int");

                    b.Property<int>("IdRecurso")
                        .HasColumnType("int");

                    b.Property<int>("IdSubtema")
                        .HasColumnType("int");

                    b.Property<int>("ValorFuncional")
                        .HasColumnType("int");

                    b.Property<int>("ValorFuncionalVerif")
                        .HasColumnType("int");

                    b.Property<int>("ValorTecnico")
                        .HasColumnType("int");

                    b.Property<int>("ValorTecnicoVerif")
                        .HasColumnType("int");

                    b.HasKey("IdConocimientoRecurso");

                    b.HasIndex("IdEvaluacion");

                    b.HasIndex("IdGrilla");

                    b.HasIndex("IdRecurso");

                    b.HasIndex("IdSubtema");

                    b.ToTable("ConocimientoRecurso");
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

            modelBuilder.Entity("WebGrilla.Models.Evaluacion", b =>
                {
                    b.Property<int>("IdEvaluacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEvaluacion"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.HasKey("IdEvaluacion");

                    b.ToTable("Evaluacion");
                });

            modelBuilder.Entity("WebGrilla.Models.Grilla", b =>
                {
                    b.Property<int>("IdGrilla")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdGrilla"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdGrilla");

                    b.ToTable("Grillas");
                });

            modelBuilder.Entity("WebGrilla.Models.GrillaSubtema", b =>
                {
                    b.Property<int>("IdGrillaSubtema")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdGrillaSubtema"), 1L, 1);

                    b.Property<int>("IdGrillaTema")
                        .HasColumnType("int");

                    b.Property<int>("IdSubtema")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Ponderacion")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("IdGrillaSubtema");

                    b.HasIndex("IdGrillaTema");

                    b.HasIndex("IdSubtema");

                    b.ToTable("GrillaSubtemas");
                });

            modelBuilder.Entity("WebGrilla.Models.GrillaTema", b =>
                {
                    b.Property<int>("IdGrillaTema")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdGrillaTema"), 1L, 1);

                    b.Property<int>("IdGrilla")
                        .HasColumnType("int");

                    b.Property<int>("IdTema")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Ponderacion")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("IdGrillaTema");

                    b.HasIndex("IdGrilla");

                    b.HasIndex("IdTema");

                    b.ToTable("GrillaTemas");
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

            modelBuilder.Entity("WebGrilla.Models.ResultadoConocimiento", b =>
                {
                    b.Property<int>("IdResultadoConocimiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdResultadoConocimiento"), 1L, 1);

                    b.Property<int>("IdEvaluacion")
                        .HasColumnType("int");

                    b.Property<int>("IdGrilla")
                        .HasColumnType("int");

                    b.Property<int>("IdRecurso")
                        .HasColumnType("int");

                    b.Property<int>("IdSubtema")
                        .HasColumnType("int");

                    b.Property<int>("Id_Subtema")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorFuncional")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("ValorTecnico")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("IdResultadoConocimiento");

                    b.HasIndex("IdEvaluacion");

                    b.HasIndex("IdGrilla");

                    b.HasIndex("IdRecurso");

                    b.HasIndex("IdSubtema");

                    b.ToTable("ResultadoConocimiento");
                });

            modelBuilder.Entity("WebGrilla.Models.Rol", b =>
                {
                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRol"), 1L, 1);

                    b.Property<int>("Nombre")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("IdRol");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WebGrilla.Models.Subtema", b =>
                {
                    b.Property<int>("IdSubtema")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSubtema"), 1L, 1);

                    b.Property<int>("IdTema")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.HasKey("IdSubtema");

                    b.HasIndex("IdTema");

                    b.ToTable("Subtemas");
                });

            modelBuilder.Entity("WebGrilla.Models.Tema", b =>
                {
                    b.Property<int>("IdTema")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTema"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.HasKey("IdTema");

                    b.ToTable("Temas");
                });

            modelBuilder.Entity("WebGrilla.Models.ConocimientoRecurso", b =>
                {
                    b.HasOne("WebGrilla.Models.Evaluacion", "Evaluacion")
                        .WithMany("Conocimientos")
                        .HasForeignKey("IdEvaluacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebGrilla.Models.Grilla", "Grilla")
                        .WithMany("Conocimientos")
                        .HasForeignKey("IdGrilla")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebGrilla.Models.Recurso", "Recurso")
                        .WithMany("Conocimientos")
                        .HasForeignKey("IdRecurso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebGrilla.Models.Subtema", "Subtema")
                        .WithMany()
                        .HasForeignKey("IdSubtema")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evaluacion");

                    b.Navigation("Grilla");

                    b.Navigation("Recurso");

                    b.Navigation("Subtema");
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

            modelBuilder.Entity("WebGrilla.Models.GrillaSubtema", b =>
                {
                    b.HasOne("WebGrilla.Models.GrillaTema", "GrillaTema")
                        .WithMany("GrillaSubtemas")
                        .HasForeignKey("IdGrillaTema")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebGrilla.Models.Subtema", "Subtema")
                        .WithMany("GrillaSubtemas")
                        .HasForeignKey("IdSubtema")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GrillaTema");

                    b.Navigation("Subtema");
                });

            modelBuilder.Entity("WebGrilla.Models.GrillaTema", b =>
                {
                    b.HasOne("WebGrilla.Models.Grilla", "Grilla")
                        .WithMany("GrillaTemas")
                        .HasForeignKey("IdGrilla")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebGrilla.Models.Tema", "Tema")
                        .WithMany("GrillaTemas")
                        .HasForeignKey("IdTema")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grilla");

                    b.Navigation("Tema");
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

            modelBuilder.Entity("WebGrilla.Models.ResultadoConocimiento", b =>
                {
                    b.HasOne("WebGrilla.Models.Evaluacion", "Evaluacion")
                        .WithMany("Resultados")
                        .HasForeignKey("IdEvaluacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebGrilla.Models.Grilla", "Grilla")
                        .WithMany("Resultados")
                        .HasForeignKey("IdGrilla")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebGrilla.Models.Recurso", "Recurso")
                        .WithMany("Resultados")
                        .HasForeignKey("IdRecurso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebGrilla.Models.GrillaSubtema", "GrillaSubtema")
                        .WithMany("Resultados")
                        .HasForeignKey("IdSubtema")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Evaluacion");

                    b.Navigation("Grilla");

                    b.Navigation("GrillaSubtema");

                    b.Navigation("Recurso");
                });

            modelBuilder.Entity("WebGrilla.Models.Subtema", b =>
                {
                    b.HasOne("WebGrilla.Models.Tema", "Tema")
                        .WithMany("Subtemas")
                        .HasForeignKey("IdTema")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Tema");
                });

            modelBuilder.Entity("WebGrilla.Models.Cliente", b =>
                {
                    b.Navigation("Equipos");
                });

            modelBuilder.Entity("WebGrilla.Models.EquipoDesarrollo", b =>
                {
                    b.Navigation("Recursos");
                });

            modelBuilder.Entity("WebGrilla.Models.Evaluacion", b =>
                {
                    b.Navigation("Conocimientos");

                    b.Navigation("Resultados");
                });

            modelBuilder.Entity("WebGrilla.Models.Grilla", b =>
                {
                    b.Navigation("Conocimientos");

                    b.Navigation("GrillaTemas");

                    b.Navigation("Resultados");
                });

            modelBuilder.Entity("WebGrilla.Models.GrillaSubtema", b =>
                {
                    b.Navigation("Resultados");
                });

            modelBuilder.Entity("WebGrilla.Models.GrillaTema", b =>
                {
                    b.Navigation("GrillaSubtemas");
                });

            modelBuilder.Entity("WebGrilla.Models.Recurso", b =>
                {
                    b.Navigation("Conocimientos");

                    b.Navigation("Resultados");
                });

            modelBuilder.Entity("WebGrilla.Models.Rol", b =>
                {
                    b.Navigation("Recursos");
                });

            modelBuilder.Entity("WebGrilla.Models.Subtema", b =>
                {
                    b.Navigation("GrillaSubtemas");
                });

            modelBuilder.Entity("WebGrilla.Models.Tema", b =>
                {
                    b.Navigation("GrillaTemas");

                    b.Navigation("Subtemas");
                });
#pragma warning restore 612, 618
        }
    }
}
