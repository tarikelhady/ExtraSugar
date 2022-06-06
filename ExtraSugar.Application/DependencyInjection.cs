using ExtraSugar.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace ExtraSugar.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services.AddScoped<IAuthenticationService, AuthenticationService>();
    }
}