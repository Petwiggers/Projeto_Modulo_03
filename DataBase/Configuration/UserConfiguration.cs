using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M3P_BackEnd_Squad1.Models;
using Microsoft.EntityFrameworkCore;

namespace M3P_BackEnd_Squad1.DataBase.Configuration
{
    public class UserConfiguration
    {
        public static void configuration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().Property(x => x.Id).HasColumnName("ID").HasColumnType("INT");
            modelBuilder.Entity<User>().Property(x => x.Name).IsRequired().HasColumnName("NAME").HasColumnType("VARCHAR(200)");
            modelBuilder.Entity<User>().Property(x => x.Email).IsRequired().HasColumnName("EMAIL").HasColumnType("VARCHAR(50)");
            modelBuilder.Entity<User>().HasIndex(x => x.Email).IsUnique();
            modelBuilder.Entity<User>().Property(x => x.Role).HasColumnName("ROLE").HasColumnType("INT").HasConversion<int>();

            modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Name = "Maria Fernanda", Email = "maria@teste.com", Role = Models.Enums.EnumRole.Gerente, },
            new User { Id = 2, Name = "Peterson Wiggers", Email = "peterson@teste.com", Role = Models.Enums.EnumRole.Gerente, },
            new User { Id = 3, Name = "Marcelo Dias", Email = "marcelo@teste.com", Role = Models.Enums.EnumRole.VerSomente, },
            new User { Id = 4, Name = "Fabio Solva", Email = "fabio@teste.com", Role = Models.Enums.EnumRole.Time, },
            new User { Id = 5, Name = "Dejacir Wiggers", Email = "dejacir@teste.com", Role = Models.Enums.EnumRole.Gerente, },
            new User { Id = 6, Name = "Stela Dias", Email = "stela@test.com", Role = Models.Enums.EnumRole.Gerente },
            new User { Id = 7, Name = "Leonardo Silva", Email = "leo@test.com", Role = Models.Enums.EnumRole.Gerente }
            );
        }
    }
}