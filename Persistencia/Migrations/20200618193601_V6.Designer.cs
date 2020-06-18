﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

namespace Persistencia.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200618193601_V6")]
    partial class V6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("Dominio.Beneficiario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("apMaterno")
                        .HasColumnType("TEXT");

                    b.Property<string>("apPaterno")
                        .HasColumnType("TEXT");

                    b.Property<string>("fecNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("parentesco")
                        .HasColumnType("TEXT");

                    b.Property<string>("sexo")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Beneficiarios");
                });

            modelBuilder.Entity("Dominio.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("apMaterno")
                        .HasColumnType("TEXT");

                    b.Property<string>("apPaterno")
                        .HasColumnType("TEXT");

                    b.Property<string>("estatus")
                        .HasColumnType("TEXT");

                    b.Property<string>("fechaContrato")
                        .HasColumnType("TEXT");

                    b.Property<string>("foto")
                        .HasColumnType("TEXT");

                    b.Property<string>("nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("puesto")
                        .HasColumnType("TEXT");

                    b.Property<int>("salario")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Empleados");
                });
#pragma warning restore 612, 618
        }
    }
}
