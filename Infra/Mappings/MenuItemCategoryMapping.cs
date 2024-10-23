using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mappings
{
    public class MenuItemCategoryMapping : IEntityTypeConfiguration<MenuItemCategory>
    {
        public void Configure(EntityTypeBuilder<MenuItemCategory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasOne(x => x.MenuItem).WithMany(i => i.MenuItemCategories).HasForeignKey(c => c.MenuItemId);
        }
    }
}
