using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M3P_BackEnd_Squad1.Models;
using Microsoft.EntityFrameworkCore;

namespace M3P_BackEnd_Squad1.DataBase.Configuration
{
    public class ModelConfiguration
    {
        public static void configuration(ModelBuilder modelBuilder)
        {
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