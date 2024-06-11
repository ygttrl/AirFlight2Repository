using AirFlight2.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Repository.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Countries");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.Property(x => x.Name).IsRequired();

            builder.HasMany(x => x.AirPorts).WithOne(x => x.Country);

            builder.HasData
                (
                    new Country {  Id=1,Name="Turkey",CreatedDate=DateTime.Now },            
                    new Country {  Id=2,Name= "Germany", CreatedDate=DateTime.Now},
                    new Country {  Id=3,Name="USA", CreatedDate = DateTime.Now } 
                );

        }
    }
}
