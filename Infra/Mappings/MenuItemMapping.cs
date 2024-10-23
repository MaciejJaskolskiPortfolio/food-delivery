using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infra.Mappings
{
    public class MenuItemMapping : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder
              .HasOne(m => m.Restaurant)
              .WithMany(r => r.MenuItems)
              .HasForeignKey(m => m.RestaurantId);
        }
    }
}
