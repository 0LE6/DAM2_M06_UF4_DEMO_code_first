﻿// <auto-generated />
using System;
using DAM2_M06_UF4_DEMO_code_first.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAM2_M06_UF4_DEMO_code_first.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20240208153014_cuarta")]
    partial class cuarta
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DAM2_M06_UF4_DEMO_code_first.Model.Alumno", b =>
                {
                    b.Property<int>("AlumnoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNacimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("NotaFinal")
                        .HasColumnType("double");

                    b.HasKey("AlumnoId");

                    b.HasIndex("CursoId");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("DAM2_M06_UF4_DEMO_code_first.Model.Curso", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("ProfesorId")
                        .HasColumnType("int");

                    b.HasKey("CursoId");

                    b.HasIndex("ProfesorId");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("DAM2_M06_UF4_DEMO_code_first.Model.Profesor", b =>
                {
                    b.Property<int>("ProfesorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ProfesorId");

                    b.ToTable("Profesor");
                });

            modelBuilder.Entity("DAM2_M06_UF4_DEMO_code_first.Model.Alumno", b =>
                {
                    b.HasOne("DAM2_M06_UF4_DEMO_code_first.Model.Curso", "Curso")
                        .WithMany("Alumnos")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAM2_M06_UF4_DEMO_code_first.Model.Curso", b =>
                {
                    b.HasOne("DAM2_M06_UF4_DEMO_code_first.Model.Profesor", "Profesor")
                        .WithMany("Cursos")
                        .HasForeignKey("ProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
