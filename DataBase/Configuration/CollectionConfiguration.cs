
using Microsoft.EntityFrameworkCore;
using M3P_BackEnd_Squad1.Models;

namespace M3P_BackEnd_Squad1.DataBase.Configuration
{
    public class CollectionConfiguration
    {
        public static void configuration(ModelBuilder modelBuilder)
        {
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

            modelBuilder.Entity<Collection>().HasData(
            new Collection
            {
                Id = 1,
                Name = "Rising of the Mountains",
                Brand = "Adidas",
                Budget = 250000,
                Color = "Red",
                ReleaseYear = new DateTime(2004, 12, 06),
                Seasons = Models.Enums.SeasonsEnum.Outono,

            },
            new Collection
            {
                Id = 2,
                Name = "Creek of love",
                Brand = "Outlet",
                Budget = 100000,
                Color = "Blue",
                ReleaseYear = new DateTime(2010, 06, 15),
                Seasons = Models.Enums.SeasonsEnum.Verão,
                Status = Models.Enums.StatusEnum.Finalizada
            },
            new Collection
            {
                Id = 3,
                Name = "Spring Flowers",
                Brand = "Adidas",
                Budget = 500000,
                Color = "White",
                ReleaseYear = new DateTime(2014, 07, 22),
                Seasons = Models.Enums.SeasonsEnum.Primavera,
                Status = Models.Enums.StatusEnum.Andamento
            },
            new Collection
            {
                Id = 4,
                Name = "Amazon of Brazil",
                Brand = "Jakarta",
                Budget = 50000,
                Color = "Black",
                ReleaseYear = new DateTime(1999, 01, 02),
                Seasons = Models.Enums.SeasonsEnum.Primavera,
                Status = Models.Enums.StatusEnum.Arquivada
            },
            new Collection
            {
                Id = 5,
                Name = "Southern Cold",
                Brand = "Umbro",
                Budget = 330700,
                Color = "Yellow",
                ReleaseYear = new DateTime(2023, 12, 17),
                Seasons = Models.Enums.SeasonsEnum.Inverno,
                Status = Models.Enums.StatusEnum.Finalizada
            }
        );
        }
    }
}