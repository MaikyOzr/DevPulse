using DevPulse.Features.ProjectFeature.CQS.CommandsHandler.Create;
using DevPulse.Features.ProjectFeature.CQS.QueriesHandler.Get;
using Microsoft.Extensions.DependencyInjection;

namespace DevPulse.Features;

public static class DependencyInjection
{
    public static IServiceCollection AddFeature(this IServiceCollection services)
    {
        services.AddScoped<GetProjectCommandHandler>();
        services.AddScoped<CreateProjectCommandHandler>();
        return services;
    }
}
