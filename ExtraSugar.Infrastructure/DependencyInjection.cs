using Microsoft.Extensions.DependencyInjection;

namespace ExtraSugar.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services;
    }
}