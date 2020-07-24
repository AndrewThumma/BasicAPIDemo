using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Contexts
{
    public class CityInfoContext : DbContext
    {

        public CityInfoContext(DbContextOptions<CityInfoContext> options)
            :base(options)  
        {
            //Database.EnsureCreated();
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<City>()
                .HasData(new City()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park"
                });
            builder.Entity<PointOfInterest>()
                .HasData(
                new PointOfInterest()
                {
                    Id=1,
                    CityId = 1,
                    Name="Central Park",
                    Description="The most visited urban park in the United States"
                });
            base.OnModelCreating(builder);
        }

    }   
}
