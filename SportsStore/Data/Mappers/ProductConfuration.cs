using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsStore.Models;

namespace SportsStore.Data.Mappers
{
    class ProductConfuration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product").HasKey(t => t.ProductId);
            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.Price);
            builder.Property(t => t.Description);

        }
    }
}
