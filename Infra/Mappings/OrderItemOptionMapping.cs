using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Infra.Mappings
{
    public class OrderItemOptionMapping : IEntityTypeConfiguration<OrderItemOption>
    {
        public void Configure(EntityTypeBuilder<OrderItemOption> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasOne(oio => oio.OrderItem)
               .WithMany(oi => oi.OrderItemOptions)
               .HasForeignKey(oio => oio.OrderItemId);

            builder.HasOne(oio => oio.MenuItemOption)
                .WithMany()
                .HasForeignKey(oio => oio.MenuItemOptionId);
        }
    }
}
