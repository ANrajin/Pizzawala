using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PizzaWala.Application.Common.Interfaces.Authentication;
using PizzaWala.Application.Common.Interfaces.Services;
using PizzaWala.Infrastructure.Authentication;
using PizzaWala.Infrastructure.Services;

namespace PizzaWala.Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            ConfigurationManager configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
            services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddScoped<IDateTimeProvider, DateTimeProvider>();
            return services;
        }
    }
}
