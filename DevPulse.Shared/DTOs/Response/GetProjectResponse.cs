using DevPulse.Shared.DTOs.Models;

namespace DevPulse.Shared.DTOs.Response;

public class GetProjectResponse
{
    public string? Name { get; set; }

    public string? RepoUrl { get; set; }

    public List<Commit> Commits { get; set; } = [];
}
