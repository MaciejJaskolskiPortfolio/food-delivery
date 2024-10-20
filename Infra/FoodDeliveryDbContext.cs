using Domain.Auth;
using Infra.Mappings;
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
            modelBuilder.ApplyConfiguration(new AddressMapping());
        }
        public void Seed()
        {

        }
    }
}
