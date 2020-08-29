using LoginProject1.Entities.Models;
using LoginProjectDal.Concrete.EF.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginProjectDal.Concrete.EF.Context
{
    public class RestaurantDBContext : DbContext
    {
        DbSet<Restaurant> Restaurants { get; set; }
        DbSet<City> Cities { get; set; }


        public RestaurantDBContext(DbContextOptions<RestaurantDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                 .ApplyConfiguration(new RestaurantConfiguration());
            modelBuilder
                .ApplyConfiguration(new CityConfiguration());
        }
    }
}
