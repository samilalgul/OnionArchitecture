using LoginProject1.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginProjectDal.Concrete.EF.Configuration
{
    public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder
                .HasKey(r => r.ResID);

            builder
                .Property(r => r.ResID)
                .UseIdentityColumn();
            builder
                .Property(r => r.ResName)
                .IsRequired()
                .HasMaxLength(100);
            builder
                .HasOne(r => r.City)
                .WithMany(c => c.Restaurants)
                .HasForeignKey(r => r.CID);
            builder
                .ToTable("Restaurants");
        }
    }
}
