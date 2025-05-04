namespace DevPulse.Infrastructure.Models;

public class CodeSmell
{
    public Guid Id { get; set; }

    public Guid CodeFileId { get; set; }

    public CodeFile? CodeFile { get; set; }

    public List<FocusSessionSmell> FocusSessions { get; set; } = [];

    public required string Type { get; set; } // make enum

    public required int LineNumber { get; set; }

    public string? Message { get; set; }

}
