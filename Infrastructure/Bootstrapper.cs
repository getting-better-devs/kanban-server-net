using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class Bootstrapper
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        AddDbContext(services);

        return services;
    }
    
    private static IServiceCollection AddDbContext(IServiceCollection services) 
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=postgres");
        });

        return services;
    }
}