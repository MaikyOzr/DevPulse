using DevPulse.Features.Interfeces;
using DevPulse.Features.ProjectFeature.DTOs.Request;
using DevPulse.Shared.Responses;

namespace DevPulse.Features.ProjectFeature.CQS.CommandsHandler.Create;

public class CreateProjectCommandHandler(IProjectRepository _project)
{
    public async Task<ApiResponse<Guid>> Handle(CreateProjectRequest command, CancellationToken cancellationToken)
    {
        var id = await _project.CreateProject(command.Name, command.RepoUrl);
        return new ApiResponse<Guid>
        {
            Data = id,
            Message = "Project created successfully",
            Success = true
        };
    }
}
