using Domain.Interfaces.Services;
using Domain.Services;

namespace FoodDeliveryApp.Registers
{
    public static class DomainRegister
    {
        public static void AddDomain(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IAuthService, AuthService>();
        }
    }
}
