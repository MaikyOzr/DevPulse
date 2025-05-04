using DevPulse.Shared.DTOs.Models;

namespace DevPulse.Features.ProjectFeature.DTOs.Response;

public class GetByIdProjectResponse
{
    public string? Name { get; set; }

    public string? RepoUrl { get; set; }

    public List<Commit> Commits { get; set; } = [];
}
