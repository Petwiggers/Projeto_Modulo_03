using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M3P_BackEnd_Squad1.Models;
using Microsoft.EntityFrameworkCore;
using M3P_BackEnd_Squad1.Utilities;

namespace M3P_BackEnd_Squad1.DataBase.Configuration
{
    public class CompanyConfiguration
    {
        public static void configuration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().ToTable("Companies");
            modelBuilder.Entity<Company>().HasKey(x => x.Id);
            modelBuilder.Entity<Company>().Property(x => x.Id).HasColumnName("ID").HasColumnType("INT");
            modelBuilder.Entity<Company>().Property(x => x.Name).IsRequired().HasColumnName("NAME").HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Company>().Property(x => x.Cnpj).IsRequired().HasColumnName("CNPJ").HasColumnType("VARCHAR(14)");
            modelBuilder.Entity<Company>().HasIndex(x => x.Cnpj).IsUnique();
            modelBuilder.Entity<Company>().Property(x => x.Manager).IsRequired().HasColumnName("MANAGER").HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<Company>().Property(x => x.Email).IsRequired().HasColumnName("EMAIL").HasColumnType("VARCHAR(50)");
            modelBuilder.Entity<Company>().Property(x => x.Password).IsRequired().HasColumnName("PASSWORD").HasColumnType("VARCHAR(200)");

            modelBuilder.Entity<Company>().HasData(
            new Company
            {
                Id = 1,
                Name = "Audaces",
                Cnpj = "77.330.993/0001-94",
                Manager = "Maria Fernanda",
                Email = "maria@teste.com",
                Password = Cryptography.CriptografarSenha("123"),
            },
            new Company
            {
                Id = 2,
                Name = "JBS",
                Cnpj = "99.146.426/0001-15",
                Manager = "Peterson Wiggers",
                Email = "peterson@teste.com",
                Password = Cryptography.CriptografarSenha("123"),
            },
            new Company
            {
                Id = 3,
                Name = "Klabin",
                Cnpj = "79.467.070/0001-04",
                Manager = "Dejacir Wiggers",
                Email = "dejacir@teste.com",
                Password = Cryptography.CriptografarSenha("123"),
            },
            new Company
            {
                Id = 4,
                Name = "Ambev",
                Cnpj = "81.961.423/0001-70",
                Manager = "Stela Dias",
                Email = "stela@test.com",
                Password = Cryptography.CriptografarSenha("123"),
            },
            new Company
            {
                Id = 1,
                Name = "Sadia",
                Cnpj = "78.613.542/0001-27",
                Manager = "Leonardo Silva",
                Email = "leo@test.com",
                Password = Cryptography.CriptografarSenha("123"),
            }
            );
        }
    }
}