using DevPulse.Features.Interfeces;
using DevPulse.Features.ProjectFeature.DTOs.Response;

namespace DevPulse.Features.ProjectFeature.CQS.QueriesHandler.Get;

public class GetByIdProjectQueryHandler(IProjectRepository _project)
{
    public Task<GetByIdProjectResponse> Handle(Guid id, CancellationToken cancellationToken)
    {
        return _project.GetProject(id);
    }
}
