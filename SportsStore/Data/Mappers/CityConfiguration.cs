using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SportsStore.Models;

namespace SportsStore.Data.Mappers
{
    class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("City").HasKey(t => t.Postalcode);
            builder.Property(t => t.Name).IsRequired();
        }
    }
}
