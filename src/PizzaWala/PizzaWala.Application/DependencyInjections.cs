using Microsoft.Extensions.DependencyInjection;
using PizzaWala.Application.Services.Authentication;

namespace PizzaWala.Application
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            return services;
        }
    }
}
