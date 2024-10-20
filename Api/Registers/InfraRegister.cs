using Domain.Interfaces.Repositories;
using Infra;
using Infra.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace FoodDeliveryApp.Registers
{
    public static class InfraRegister
    {
        public static void AddInfra(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<FoodDeliveryDbContext>(x => UseNpgsql(x, configuration));

            serviceCollection.AddScoped<IAddressRepository, AddressRepository>();
            //serviceCollection.AddScoped<IConcertRepository, ConcertRepository>();
            //serviceCollection.AddScoped<ITourRepository, TourRepository>();
            //serviceCollection.AddScoped<IAlbumManagerRepository, AlbumManagerRepository>();
            //serviceCollection.AddScoped<INotificationRepository, NotificationRepository>();
            //serviceCollection.AddScoped<IFollowRepository, FollowRepository>();

        }

        /**
         * Tests fail if void
         */
        public static async Task ConfigureInfra(this IApplicationBuilder applicationBuilder)
        {
            var serviceScope = applicationBuilder.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();
            var context = serviceScope.ServiceProvider.GetRequiredService<FoodDeliveryDbContext>();

            context.Database.Migrate();
            context.Seed();
        }

        private static void UseNpgsql(DbContextOptionsBuilder options, IConfiguration configuration)
        {
            options.UseNpgsql(GetConnectionDefaultString(configuration));
            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            options.EnableDetailedErrors();
        }

        private static string GetConnectionDefaultString(IConfiguration configuration) =>
            configuration.GetConnectionString("DefaultConnection");

        private static void EnableRetryOnFailure(SqlServerDbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.EnableRetryOnFailure(10, TimeSpan.FromSeconds(30), null);
    }
}
