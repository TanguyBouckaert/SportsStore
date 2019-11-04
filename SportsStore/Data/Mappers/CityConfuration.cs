using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SportsStore.Models;

namespace SportsStore.Data.Mappers
{
    class CityConfuration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("City").HasKey(t => t.Postalcode);
            builder.Property(t => t.Name).IsRequired();
        }
    }
}
