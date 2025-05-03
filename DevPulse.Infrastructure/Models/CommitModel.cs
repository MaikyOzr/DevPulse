
namespace DevPulse.Infrastructure.Models;

public class CommitModel
{
    public Guid Id { get; set; }

    public required string CommitHash { get; set; }

    public required string Author { get; set; }

    public string? Message { get; set; }

    public DateTime Timestamp { get; set; }

    public required Guid ProjectId { get; set; }
 
    public ProjectModel? Project { get; set; }
}
