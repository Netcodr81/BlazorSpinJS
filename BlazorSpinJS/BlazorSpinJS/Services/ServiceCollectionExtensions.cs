using BlazorSpinJS.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BlazorSpinJS.Services;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBlazorSpinner(this IServiceCollection services, Action<SpinnerOptions> options)
    {
        SpinnerOptions spinnerOptions = new SpinnerOptions();
        options?.Invoke(spinnerOptions);

        services.AddScoped<ISpinnerOptionsService, SpinnerOptionsService>(x => new SpinnerOptionsService(spinnerOptions));
        services.AddScoped<ISpinnerService, SpinnerService>(x => new SpinnerService());
        return services;
    }

    public static IServiceCollection AddBlazorSpinner(this IServiceCollection services)
    {
        SpinnerOptions spinnerOptions = new SpinnerOptions();

        services.AddScoped<ISpinnerOptionsService, SpinnerOptionsService>(x => new SpinnerOptionsService(spinnerOptions));
        services.AddScoped<ISpinnerService, SpinnerService>(x => new SpinnerService());
        return services;
    }

}
