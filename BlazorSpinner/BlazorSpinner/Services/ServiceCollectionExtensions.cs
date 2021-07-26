using Microsoft.Extensions.DependencyInjection;

namespace BlazorSpinner.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazorSpinner(this IServiceCollection services)
        {
            return services.AddScoped<ISpinnerService, SpinnerService>(x => new SpinnerService());

        }

    }
}
