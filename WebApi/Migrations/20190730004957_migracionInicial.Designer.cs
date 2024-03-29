﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Models;

namespace WebApi.Migrations
{
    [DbContext(typeof(WebApiContext))]
    [Migration("20190730004957_migracionInicial")]
    partial class migracionInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi.Models.Pais", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Habitantes");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Pais");

                    b.HasData(
                        new { Id = new Guid("89d1b095-f34c-4341-bcab-599330589826"), Habitantes = 46000000, Nombre = "España" },
                        new { Id = new Guid("2354ded8-148e-4a16-b391-c2011de35ad0"), Habitantes = 468200000, Nombre = "Alemania" },
                        new { Id = new Guid("79ab5086-0556-4800-ab20-6f83763ebe54"), Habitantes = 1500000, Nombre = "Francia" },
                        new { Id = new Guid("47f4e525-db5a-49bc-8452-3fbdf61e2cc8"), Habitantes = 62820000, Nombre = "Italia" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
