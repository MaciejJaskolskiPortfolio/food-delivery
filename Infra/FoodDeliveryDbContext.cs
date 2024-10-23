using Domain.Auth;
using Infra.Mappings;
using Infra.Seed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class FoodDeliveryDbContext : IdentityDbContext<AuthUser>
    {
        public FoodDeliveryDbContext() { }
        public FoodDeliveryDbContext(DbContextOptions<FoodDeliveryDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            AddMappingConfiguration(modelBuilder);
            AddSeeds(modelBuilder);
        }

        private void AddMappingConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressMapping());
            modelBuilder.ApplyConfiguration(new RestaurantMapping());
            modelBuilder.ApplyConfiguration(new MenuItemCategoryMapping());
            modelBuilder.ApplyConfiguration(new MenuItemOptionMapping());
            modelBuilder.ApplyConfiguration(new MenuItemMapping());
            modelBuilder.ApplyConfiguration(new OrderMapping());
            modelBuilder.ApplyConfiguration(new OrderItemMapping());
            modelBuilder.ApplyConfiguration(new OrderItemOptionMapping());
            modelBuilder.ApplyConfiguration(new ClientMapping());
            modelBuilder.ApplyConfiguration(new DeliveryDriverMapping());
        }

        private void AddSeeds(ModelBuilder modelBuilder)
        {
            AddressSeed.AddAddresses(modelBuilder);
        }
    }
}
