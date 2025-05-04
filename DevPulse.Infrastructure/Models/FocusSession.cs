
namespace DevPulse.Infrastructure.Models;

public class FocusSession
{
    public Guid Id { get; set; }

    public required DateTime StartedAt { get; set; }

    public DateTime? EndedAt { get; set; }   

    public string? GoalDescription { get; set; }

    public required Guid ProjectId { get; set; }

    public Project? Project { get; set; }

    public List<FocusSessionSmell> TargetSmells { get; set; } = [];
}
