using Application.UseCases.Task.Create;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class Bootstrapper
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        AddFluentValidation(services);
        AddUseCases(services);
        
        return services;
    }
    
    private static void AddFluentValidation(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(typeof(Bootstrapper).Assembly);
    }
    
    private static void AddUseCases(this IServiceCollection services)
    {
        services
            .AddScoped<ICreateTaskUseCase, CreateTaskUseCase>();
    }
}