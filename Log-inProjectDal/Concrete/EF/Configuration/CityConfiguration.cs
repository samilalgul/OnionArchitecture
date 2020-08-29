using LoginProject1.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginProjectDal.Concrete.EF.Configuration
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {

            builder
                .HasKey(c => c.CityID);

            builder
                .Property(r => r.CityID)
                .UseIdentityColumn();

            builder
                .Property(r => r.CityName)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .ToTable("Cities");
        }
    }
}
