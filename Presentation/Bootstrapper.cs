﻿using Microsoft.Extensions.DependencyInjection;

namespace Presentation;

public static class Bootstrapper
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        return services;
    }
}