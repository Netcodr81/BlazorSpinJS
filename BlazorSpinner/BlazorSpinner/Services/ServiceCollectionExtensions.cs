using BlazorSpinner.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSpinner.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazorSpinner(this IServiceCollection services, SpinnerOptions options = null)
        {
            if (options == null)
            {
                return services.AddScoped<ISpinnerService, SpinnerService>(x => new SpinnerService(new SpinnerOptions()));
            }
            else
            {
                return services.AddScoped<ISpinnerService, SpinnerService>(x => new SpinnerService());
            }
        }
    }
}
