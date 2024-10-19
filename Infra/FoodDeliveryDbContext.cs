using Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class FoodDeliveryDbContext : DbContext
    {
        public FoodDeliveryDbContext() { }
        public FoodDeliveryDbContext(DbContextOptions<FoodDeliveryDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AddressMapping());
        }
    }
}
