﻿// <auto-generated />
using System;
using M3P_BackEnd_Squad1.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace M3P_BackEnd_Squad1.Migrations
{
    [DbContext(typeof(LabClothingCollectionDbContext))]
    partial class LabClothingCollectionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("M3P_BackEnd_Squad1.Models.Collection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("BRAND");

                    b.Property<decimal>("Budget")
                        .HasColumnType("DECIMAL(18, 2)")
                        .HasColumnName("BUDGET");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("VARCHAR(80)")
                        .HasColumnName("COLOR");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("NAME");

                    b.Property<DateTime>("ReleaseYear")
                        .HasColumnType("DATE")
                        .HasColumnName("RELEASE_YEAR");

                    b.Property<int>("Seasons")
                        .HasColumnType("INT")
                        .HasColumnName("SEASONS");

                    b.Property<int>("Status")
                        .HasColumnType("INT")
                        .HasColumnName("STATUS");

                    b.HasKey("Id");

                    b.ToTable("Collections", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Adidas",
                            Budget = 250000m,
                            Color = "Red",
                            Name = "Rising of the Mountains",
                            ReleaseYear = new DateTime(2004, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Seasons = 0,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Outlet",
                            Budget = 100000m,
                            Color = "Blue",
                            Name = "Creek of love",
                            ReleaseYear = new DateTime(2010, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Seasons = 3,
                            Status = 2
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Adidas",
                            Budget = 500000m,
                            Color = "White",
                            Name = "Spring Flowers",
                            ReleaseYear = new DateTime(2014, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Seasons = 2,
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Jakarta",
                            Budget = 50000m,
                            Color = "Black",
                            Name = "Amazon of Brazil",
                            ReleaseYear = new DateTime(1999, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Seasons = 2,
                            Status = 3
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Umbro",
                            Budget = 330700m,
                            Color = "Yellow",
                            Name = "Southern Cold",
                            ReleaseYear = new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Seasons = 1,
                            Status = 2
                        });
                });

            modelBuilder.Entity("M3P_BackEnd_Squad1.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("VARCHAR(14)")
                        .HasColumnName("CNPJ");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("MANAGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("NAME");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("PASSWORD");

                    b.HasKey("Id");

                    b.HasIndex("Cnpj")
                        .IsUnique();

                    b.ToTable("Companies", (string)null);
                });

            modelBuilder.Entity("M3P_BackEnd_Squad1.Models.CompanySetup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyID")
                        .HasColumnType("INT")
                        .HasColumnName("COMPANY_FK");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("LOGO");

                    b.Property<int>("Tema")
                        .HasColumnType("INT")
                        .HasColumnName("TEMA");

                    b.HasKey("Id");

                    b.HasIndex("CompanyID");

                    b.ToTable("CompaniesSetup", (string)null);
                });

            modelBuilder.Entity("M3P_BackEnd_Squad1.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CollectionID")
                        .HasColumnType("INT")
                        .HasColumnName("Collection_FK");

                    b.Property<bool>("Embroidery")
                        .HasColumnType("BIT")
                        .HasColumnName("EMBROIDERY");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("NAME");

                    b.Property<bool>("Print")
                        .HasColumnType("BIT")
                        .HasColumnName("PRINT");

                    b.Property<decimal>("RealCost")
                        .HasColumnType("DECIMAL(14, 2)")
                        .HasColumnName("REAL_COST");

                    b.Property<int>("ResponsibleID")
                        .HasColumnType("INT")
                        .HasColumnName("Responsible_FK");

                    b.Property<int>("Type")
                        .HasColumnType("INT")
                        .HasColumnName("TYPE");

                    b.HasKey("Id");

                    b.HasIndex("CollectionID");

                    b.HasIndex("ResponsibleID");

                    b.ToTable("Models", (string)null);
                });

            modelBuilder.Entity("M3P_BackEnd_Squad1.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)")
                        .HasColumnName("NAME");

                    b.Property<int>("Role")
                        .HasColumnType("INT")
                        .HasColumnName("ROLE");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Maria@teste.com",
                            Name = "Maria Fernanda",
                            Role = 0
                        },
                        new
                        {
                            Id = 2,
                            Email = "peterson@teste.com",
                            Name = "Peterson Wiggers",
                            Role = 1
                        },
                        new
                        {
                            Id = 3,
                            Email = "marcelo@teste.com",
                            Name = "Marcelo Dias",
                            Role = 2
                        },
                        new
                        {
                            Id = 4,
                            Email = "fabio@teste.com",
                            Name = "Fabio Solva",
                            Role = 1
                        },
                        new
                        {
                            Id = 5,
                            Email = "dejacir@teste.com",
                            Name = "Dejacir Wiggers",
                            Role = 0
                        });
                });

            modelBuilder.Entity("M3P_BackEnd_Squad1.Models.CompanySetup", b =>
                {
                    b.HasOne("M3P_BackEnd_Squad1.Models.Company", "Company")
                        .WithMany("CompaniesSetups")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("M3P_BackEnd_Squad1.Models.Model", b =>
                {
                    b.HasOne("M3P_BackEnd_Squad1.Models.Collection", "Collection")
                        .WithMany("Models")
                        .HasForeignKey("CollectionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("M3P_BackEnd_Squad1.Models.User", "Responsible")
                        .WithMany("Models")
                        .HasForeignKey("ResponsibleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collection");

                    b.Navigation("Responsible");
                });

            modelBuilder.Entity("M3P_BackEnd_Squad1.Models.Collection", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("M3P_BackEnd_Squad1.Models.Company", b =>
                {
                    b.Navigation("CompaniesSetups");
                });

            modelBuilder.Entity("M3P_BackEnd_Squad1.Models.User", b =>
                {
                    b.Navigation("Models");
                });
#pragma warning restore 612, 618
        }
    }
}
