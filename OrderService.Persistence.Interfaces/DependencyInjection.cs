using Microsoft.Extensions.DependencyInjection;

namespace OrderService.Persistence.Interfaces
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddScoped(provider => provider.GetService<IUnitOfWork>());

            return services;
        }
    }
}