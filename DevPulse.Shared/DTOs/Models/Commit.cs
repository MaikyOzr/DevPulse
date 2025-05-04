namespace DevPulse.Shared.DTOs.Models;

public class Commit
{
    public required string CommitHash { get; set; }

    public required string Author { get; set; }

    public string? Message { get; set; }

    public DateTime Timestamp { get; set; }
}
