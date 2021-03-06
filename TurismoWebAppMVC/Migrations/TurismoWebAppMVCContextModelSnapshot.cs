﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TurismoWebAppMVC.Models;

namespace TurismoWebAppMVC.Migrations
{
    [DbContext(typeof(TurismoWebAppMVCContext))]
    partial class TurismoWebAppMVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TurismoWebAppMVC.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("UF");

                    b.HasKey("Id");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("TurismoWebAppMVC.Models.Guia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Guia");
                });

            modelBuilder.Entity("TurismoWebAppMVC.Models.PontoTuristico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Descricao");

                    b.Property<int>("EstadoId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("PontoTuristico");
                });

            modelBuilder.Entity("TurismoWebAppMVC.Models.Viagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataViagem");

                    b.Property<string>("Guia");

                    b.Property<int>("PontoTuristicoId");

                    b.HasKey("Id");

                    b.ToTable("Viagem");
                });

            modelBuilder.Entity("TurismoWebAppMVC.Models.PontoTuristico", b =>
                {
                    b.HasOne("TurismoWebAppMVC.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
