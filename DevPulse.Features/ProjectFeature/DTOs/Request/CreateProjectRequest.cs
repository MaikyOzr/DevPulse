namespace DevPulse.Features.ProjectFeature.DTOs.Request;

public class CreateProjectRequest
{
    public required string Name { get; set; }
    public required string RepoUrl { get; set; }
}
