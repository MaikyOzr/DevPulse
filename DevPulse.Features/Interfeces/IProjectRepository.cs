using DevPulse.Features.ProjectFeature.DTOs.Response;

namespace DevPulse.Features.Interfeces;

public interface IProjectRepository
{
    public Task<bool> AddProjectToUser(Guid projectId, Guid userId);

    public Task<Guid> CreateProject(string name, string repoUrl);

    public Task<bool> DeleteProject(Guid id);

    public Task<bool> RemoveProjectFromUser(Guid projectId, Guid userId);

    public Task<bool> UpdateProject(Guid id, string name, string repoUrl);

    public Task<GetProjectResponse> GetProject(Guid id);
}
