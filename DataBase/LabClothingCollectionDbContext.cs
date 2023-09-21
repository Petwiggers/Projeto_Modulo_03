using Microsoft.EntityFrameworkCore;
using M3P_BackEnd_Squad1.Models;
using M3P_BackEnd_Squad1.Models.Enums;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace M3P_BackEnd_Squad1.DataBase
{
    public class LabClothingCollectionDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanySetup> CompaniesSetups { get; set; }
        public virtual DbSet<Collection> Collections { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=labclothingcollectiondb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");

            modelBuilder.Entity<User>().HasKey(x => x.Id);

            modelBuilder.Entity<User>().Property(x => x.Id).HasColumnName("ID").HasColumnType("INT");
            modelBuilder.Entity<User>().Property(x => x.Name).IsRequired().HasColumnName("NAME").HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<User>().Property(x => x.Email).IsRequired().HasColumnName("EMAIL").HasColumnType("VARCHAR(50)");
            modelBuilder.Entity<User>().HasIndex(x => x.Email).IsUnique();

            modelBuilder.Entity<User>().Property(x => x.Role).HasColumnName("ROLE").HasColumnType("INT").HasConversion<int>();


            modelBuilder.Entity<Company>().ToTable("Companies");

            modelBuilder.Entity<Company>().HasKey(x => x.Id);

            modelBuilder.Entity<Company>().Property(x => x.Id).HasColumnName("ID").HasColumnType("INT");
            modelBuilder.Entity<Company>().Property(x => x.Name).IsRequired().HasColumnName("NAME").HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Company>().Property(x => x.Cnpj).IsRequired().HasColumnName("CNPJ").HasColumnType("VARCHAR(14)");
            modelBuilder.Entity<Company>().HasIndex(x => x.Cnpj).IsUnique();
            modelBuilder.Entity<Company>().Property(x => x.Manager).IsRequired().HasColumnName("MANAGER").HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Company>().Property(x => x.Email).IsRequired().HasColumnName("EMAIL").HasColumnType("VARCHAR(50)");
            modelBuilder.Entity<Company>().Property(x => x.Password).IsRequired().HasColumnName("PASSWORD").HasColumnType("VARCHAR(200)");


            modelBuilder.Entity<CompanySetup>().ToTable("CompaniesSetup");

            modelBuilder.Entity<CompanySetup>().HasKey(x => x.Id);

            modelBuilder.Entity<CompanySetup>().Property(x => x.Id).HasColumnName("ID").HasColumnType("INT");
            modelBuilder.Entity<CompanySetup>().Property(x => x.Tema).IsRequired().HasColumnName("TEMA").HasColumnType("INT").HasConversion<int>();
            modelBuilder.Entity<CompanySetup>().Property(x => x.Logo).IsRequired().HasColumnName("LOGO").HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<CompanySetup>().Property(x => x.CompanyID).IsRequired().HasColumnName("COMPANY_FK").HasColumnType("INT");
            modelBuilder.Entity<CompanySetup>().HasOne(x => x.Company).WithMany(x => x.CompaniesSetups).HasForeignKey(x => x.CompanyID).OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Collection>().ToTable("Collections");

            modelBuilder.Entity<Collection>().HasKey(x => x.Id);

            modelBuilder.Entity<Collection>().Property(x => x.Id).HasColumnName("ID").HasColumnType("INT");
            modelBuilder.Entity<Collection>().Property(x => x.Name).IsRequired().HasColumnName("NAME").HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Collection>().Property(x => x.Brand).IsRequired().HasColumnName("BRAND").HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Collection>().Property(x => x.Budget).IsRequired().HasColumnName("BUDGET").HasColumnType("DECIMAL(18, 2)");
            modelBuilder.Entity<Collection>().Property(x => x.Color).IsRequired().HasColumnName("COLOR").HasColumnType("VARCHAR(80)");
            modelBuilder.Entity<Collection>().Property(x => x.ReleaseYear).HasColumnName("RELEASE_YEAR").HasColumnType("DATE");
            modelBuilder.Entity<Collection>().Property(x => x.Seasons).IsRequired().HasColumnName("SEASONS").HasColumnType("INT").HasConversion<int>();
            modelBuilder.Entity<Collection>().Property(x => x.Status).HasColumnName("STATUS").HasColumnType("INT").HasConversion<int>();

            modelBuilder.Entity<Model>().ToTable("Models");

            modelBuilder.Entity<Model>().HasKey(x => x.Id);

            modelBuilder.Entity<Model>().Property(x => x.Id).HasColumnName("ID").HasColumnType("INT");
            modelBuilder.Entity<Model>().Property(x => x.Name).IsRequired().HasColumnName("NAME").HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Model>().Property(x => x.ResponsibleID).IsRequired().HasColumnName("Responsible_FK").HasColumnType("INT");
            modelBuilder.Entity<Model>().HasOne(x => x.Responsible).WithMany(x => x.Models).HasForeignKey(x => x.ResponsibleID).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Model>().Property(x => x.CollectionID).IsRequired().HasColumnName("Collection_FK").HasColumnType("INT");
            modelBuilder.Entity<Model>().HasOne(x => x.Collection).WithMany(x => x.Models).HasForeignKey(x => x.CollectionID).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Model>().Property(x => x.RealCost).IsRequired().HasColumnName("REAL_COST").HasColumnType("DECIMAL(14, 2)");
            modelBuilder.Entity<Model>().Property(x => x.Type).IsRequired().HasColumnName("TYPE").HasColumnType("INT").HasConversion<int>();
            modelBuilder.Entity<Model>().Property(x => x.Embroidery).IsRequired().HasColumnName("EMBROIDERY").HasColumnType("BIT");
            modelBuilder.Entity<Model>().Property(x => x.Print).IsRequired().HasColumnName("PRINT").HasColumnType("BIT");

        }
    }
}
