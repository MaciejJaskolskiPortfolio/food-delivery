using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mappings
{
    public class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).IsRequired();

            builder.HasOne(o => o.Restaurant)
                .WithMany()
                .HasForeignKey(o => o.RestaurantId);

            builder.HasOne(o => o.DeliveryDriver)
                .WithMany(d => d.Orders)
                .HasForeignKey(o => o.DeliveryDriverId);

            builder.HasOne(o => o.Client)
                .WithMany(d => d.Orders)
                .HasForeignKey(o => o.ClientId);
        }
    }
}
