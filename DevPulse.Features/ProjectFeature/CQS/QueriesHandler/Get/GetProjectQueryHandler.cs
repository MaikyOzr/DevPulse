using DevPulse.Features.Interfeces;
using DevPulse.Shared.DTOs.Response;

namespace DevPulse.Features.ProjectFeature.CQS.QueriesHandler.Get;

public class GetProjectQueryHandler(IProjectRepository _project)
{
    public Task<GetProjectResponse> Handle(CancellationToken cancellationToken)
    {
        return _project.GetProjects();
    }
}
