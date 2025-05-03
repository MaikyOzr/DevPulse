using DevPulse.Features.Interfeces;
using DevPulse.Features.ProjectFeature.DTOs.Response;
using DevPulse.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace DevPulse.Infrastructure.Repositories
{
    public class ProjectRepository(AppDbContext appDbContext) : IProjectRepository
    {
        public Task<bool> AddProjectToUser(Guid projectId, Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task<Guid> CreateProject(string name, string repoUrl)
        {
            var project = new ProjectModel
            {
                Name = name,
                RepoUrl = repoUrl
            };
            appDbContext.Projects.Add(project);
            await appDbContext.SaveChangesAsync();
            return project.Id;
        }

        public Task<bool> DeleteProject(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<GetProjectResponse> GetProject(Guid id)
        {
           return await appDbContext.Projects
                .Where(x => x.Id == id)
                .Select(p => new GetProjectResponse
                {
                    Name = p.Name,
                    RepoUrl = p.RepoUrl
                })
                .FirstOrDefaultAsync() ?? throw new Exception("Project not found");
        }

        public Task<bool> RemoveProjectFromUser(Guid projectId, Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProject(Guid id, string name, string repoUrl)
        {
            throw new NotImplementedException();
        }
    }
}
