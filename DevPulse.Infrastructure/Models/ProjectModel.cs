
namespace DevPulse.Infrastructure.Models;

public class ProjectModel
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public required string RepoUrl { get; set; }

    public List<CommitModel> Commits { get; set; } = [];

    public List<FocusSessionModel> FocusSessions { get; set; } = [];
}
