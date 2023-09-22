
using M3P_BackEnd_Squad1.Models;
using Microsoft.EntityFrameworkCore;

namespace M3P_BackEnd_Squad1.DataBase.Configuration
{
    public class CompanySetupConfiguration
    {
        public static void configuration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanySetup>().ToTable("CompaniesSetup");
            modelBuilder.Entity<CompanySetup>().HasKey(x => x.Id);
            modelBuilder.Entity<CompanySetup>().Property(x => x.Id).HasColumnName("ID").HasColumnType("INT");
            modelBuilder.Entity<CompanySetup>().Property(x => x.Tema).IsRequired().HasColumnName("TEMA").HasColumnType("INT").HasConversion<int>();
            modelBuilder.Entity<CompanySetup>().Property(x => x.Logo).IsRequired().HasColumnName("LOGO").HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<CompanySetup>().Property(x => x.CompanyID).IsRequired().HasColumnName("COMPANY_FK").HasColumnType("INT");
            modelBuilder.Entity<CompanySetup>().HasOne(x => x.Company).WithMany(x => x.CompaniesSetups).HasForeignKey(x => x.CompanyID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}