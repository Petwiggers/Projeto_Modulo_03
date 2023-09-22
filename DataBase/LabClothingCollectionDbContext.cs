using Microsoft.EntityFrameworkCore;
using M3P_BackEnd_Squad1.Models;
using M3P_BackEnd_Squad1.Models.Enums;
using System.Collections.Generic;
using System.Reflection.Emit;
using M3P_BackEnd_Squad1.DataBase.Configuration;

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
            CollectionConfiguration.configuration(modelBuilder);
            CompanyConfiguration.configuration(modelBuilder);
            ModelConfiguration.configuration(modelBuilder);
            UserConfiguration.configuration(modelBuilder);
            CompanySetupConfiguration.configuration(modelBuilder);
        }
    }
}
