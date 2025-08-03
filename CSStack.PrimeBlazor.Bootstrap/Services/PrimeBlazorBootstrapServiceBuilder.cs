using Microsoft.Extensions.DependencyInjection;

namespace CSStack.PrimeBlazor.Bootstrap
{
    public static class PrimeBlazorBootstrapServiceBuilder
    {
        public static IServiceCollection AddPrimeBlazorBootstrap(this IServiceCollection services)
        {
            services.AddSingleton(new DialogService());
            services.AddSingleton(new NotificationService());
            return services;
        }
    }
}