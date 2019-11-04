using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsStore.Models;

namespace SportsStore.Data.Mappers
{
    class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer").HasKey(t => t.CustomerId);
            builder.HasOne(t => t.City).WithMany().IsRequired();
            builder.Property(t => t.CustomerName);
            builder.Property(t => t.FirstName);
            builder.Property(t => t.Name);
            builder.Property(t => t.Street);
        }
    }
}
