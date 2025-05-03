
namespace DevPulse.Infrastructure.Models;

public class FocusSessionModel
{
    public Guid Id { get; set; }

    public required DateTime StartedAt { get; set; }

    public DateTime? EndedAt { get; set; }   

    public string? Notes { get; set; }

    public required Guid ProjectId { get; set; }

    public ProjectModel? Project { get; set; }
}
