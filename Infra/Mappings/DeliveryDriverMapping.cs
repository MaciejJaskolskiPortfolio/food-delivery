using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mappings
{
    public class DeliveryDriverMapping : IEntityTypeConfiguration<DeliveryDriver>
    {
        public void Configure(EntityTypeBuilder<DeliveryDriver> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();


        }
    }
}
