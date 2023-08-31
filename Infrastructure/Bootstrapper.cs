using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class Bootstrapper
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        AddDbContext(services);
    }
    
    private static void AddDbContext(IServiceCollection services) 
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=postgres");
        });
    }
}