// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using GuayaswestSample.infrastructure.data;

namespace infrastructure.data.Migrations
{
    [DbContext(typeof(GuayaswestSampleContexto))]
    [Migration("20211021214017_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("GuayaswestSample.core.entities.GuayaswestSampleEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Activo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<DateTime>("FechaCreacionRegistro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18, 4)");

                    b.HasKey("Id");

                    b.ToTable("GuayaswestSampleEntity");

                    b.HasData(
                        new
                        {
                            Id = new Guid("44ba65f8-ec30-4092-8beb-b952bf0c30df"),
                            Activo = true,
                            Descripcion = "mockData1",
                            FechaCreacionRegistro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "mockData1",
                            Valor = 123m
                        },
                        new
                        {
                            Id = new Guid("ad1100bb-ee24-4444-8289-dfe712891324"),
                            Activo = true,
                            Descripcion = "mockData2",
                            FechaCreacionRegistro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "mockData2",
                            Valor = 456m
                        },
                        new
                        {
                            Id = new Guid("0a696949-c4f3-4397-b330-b978ee48801d"),
                            Activo = true,
                            Descripcion = "mockData3",
                            FechaCreacionRegistro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "mockData3",
                            Valor = 678m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
