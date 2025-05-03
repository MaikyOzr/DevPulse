using DevPulse.Features.Interfeces;
using DevPulse.Features.ProjectFeature.DTOs.Request;
using DevPulse.Features.ProjectFeature.DTOs.Response;

namespace DevPulse.Features.ProjectFeature.CQS.CommandsHandler.Create;

public class CreateProjectCommandHandler(IProjectRepository _project)
{
    public async Task<CreateProjectResponse> Handle(CreateProjectRequest command, CancellationToken cancellationToken)
    {
        var id = await _project.CreateProject(command.Name, command.RepoUrl);
        return new CreateProjectResponse{ Id = id };
    }
}
