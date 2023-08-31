using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class Bootstrapper
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}