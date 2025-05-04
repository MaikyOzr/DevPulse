using DevPulse.Features.Interfeces;
using DevPulse.Features.ProjectFeature.CQS.CommandsHandler.Create;
using DevPulse.Features.ProjectFeature.DTOs.Request;
using DevPulse.Features.ProjectFeature.DTOs.Response;
using System.Threading;

namespace DevPulse.Api.Endpoints;

public static class ProjectEndpoints
{
    public static IEndpointRouteBuilder MapProjectEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/projects");

        group.MapGet("/{id}", async (IProjectRepository repo, Guid id) =>
        {
            var projects = await repo.GetProject(id);
            return Results.Ok(projects);
        });

        group.MapPost("/", async (CreateProjectRequest request, CreateProjectCommandHandler handler) =>
        {
            var response = await handler.Handle(request, CancellationToken.None);
            return Results.Created($"/projects/{response.Data}", response);
        });

        return app;
    }
}
