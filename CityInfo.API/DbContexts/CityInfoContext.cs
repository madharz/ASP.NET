using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace CityInfo.API.DbContexts
{
    public class CityInfoContext: DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PointOfInterest> PointOfInterests { get; set;} = null!;

        public CityInfoContext(DbContextOptions<CityInfoContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasData(
                new City("Kyiv")
                {
                    Id = 1,
                    Description = "Divided by the Dnipro River"

                },
                new City("Lviv")
                {
                    Id = 2,
                    Description = "The largest cemetery is Lychakivskoye"
                },
                new City("Ivano-Frankivsk")
                {
                    Id = 3,
                    Description = "The Old Man Lives There"
                });

            modelBuilder.Entity<PointOfInterest>()
                .HasData(
                new PointOfInterest("Shevchenko Park")
                {
                    Id = 1,
                    CityId = 1,
                    Description = "Near it is located the red building of the KNU"
                },
                new PointOfInterest("Glass bridge")
                {
                    Id = 2,
                    CityId = 1,
                    Description = "This bridge was built by the mayor of Kyiv"
                },
                new PointOfInterest("Town hall")
                {
                    Id = 3,
                    CityId = 2,
                    Description = "Lviv city administration building"

                },
                new PointOfInterest("Lviv Opera House")
                {
                    Id = 4,
                    CityId = 2,
                    Description = "Named after the famous Ukrainian opera singer Solomiya Krushelnitskaya"
                },
                new PointOfInterest("Ivano-Frankivsk Town Hall")
                {
                    Id = 5,
                    CityId = 3,
                    Description = "Building in the center of Ivano-Frankivsk on Rynok Square"
                },
                new PointOfInterest("Market Square")
                {
                    Id = 6,
                    CityId = 3,
                    Description = "Main square of Ivano-Frankivsk, historical city center"
                });

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
