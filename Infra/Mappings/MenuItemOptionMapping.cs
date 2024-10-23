using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infra.Mappings
{
    public class MenuItemOptionMapping : IEntityTypeConfiguration<MenuItemOption>
    {
        public void Configure(EntityTypeBuilder<MenuItemOption> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.HasOne(x => x.MenuItemCategory).WithMany(c => c.MenuItemOptions).HasForeignKey(o => o.MenuItemCategoryId);
        }
    }
}
