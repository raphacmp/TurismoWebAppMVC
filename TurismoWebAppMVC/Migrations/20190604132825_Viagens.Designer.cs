﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TurismoWebAppMVC.Models;

namespace TurismoWebAppMVC.Migrations
{
    [DbContext(typeof(TurismoWebAppMVCContext))]
    [Migration("20190604132825_Viagens")]
    partial class Viagens
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TurismoWebAppMVC.Models.PontoTuristico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.Property<string>("Uf");

                    b.HasKey("Id");

                    b.ToTable("PontoTuristico");
                });

            modelBuilder.Entity("TurismoWebAppMVC.Models.Viagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Guia");

                    b.Property<int>("PontoTuristicoId");

                    b.HasKey("Id");

                    b.ToTable("Viagem");
                });
#pragma warning restore 612, 618
        }
    }
}
