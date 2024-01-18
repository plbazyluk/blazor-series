using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSeries.ActionIndicatorsWithMediator;

public static class Configure
{
    public static IServiceCollection AddActionIndicatorsWithMediator(this IServiceCollection services)
    {
        services.AddMediatR(options =>
        {
            options.RegisterServicesFromAssembly(typeof(Configure).Assembly);
        });

        return services;
    }
}
