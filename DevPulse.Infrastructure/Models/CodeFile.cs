namespace DevPulse.Infrastructure.Models;

public class CodeFile
{
    public Guid Id { get; set; }

    public Guid ProjectId { get; set; }

    public Project? Project { get; set; }

    public required string Path { get; set; }

    public required string Content { get; set; }    

    public List<CodeSmell> Smells { get; set; } = [];
}
