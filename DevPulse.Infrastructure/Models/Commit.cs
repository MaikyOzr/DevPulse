
namespace DevPulse.Infrastructure.Models;

public class Commit
{
    public Guid Id { get; set; }

    public required string CommitHash { get; set; }

    public required string Author { get; set; }

    public string? Message { get; set; }

    public DateTime Timestamp { get; set; }

    public required Guid ProjectId { get; set; }
 
    public Project? Project { get; set; }
}
