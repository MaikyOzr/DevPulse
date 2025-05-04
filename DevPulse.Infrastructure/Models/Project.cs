
namespace DevPulse.Infrastructure.Models;

public class Project
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public required string RepoUrl { get; set; }

    public List<Commit> Commits { get; set; } = [];

    public List<FocusSession> FocusSessions { get; set; } = [];

    public List<CodeFile> CodeFiles { get; set; } = [];
}
