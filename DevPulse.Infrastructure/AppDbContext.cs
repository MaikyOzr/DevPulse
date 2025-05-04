using DevPulse.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;


namespace DevPulse.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Project> Projects { get; set; }

    public DbSet<Commit> Commits { get; set; }

    public DbSet<FocusSession> FocusSessions { get; set; }

    public DbSet<CodeFile> CodeFiles { get; set; }

    public DbSet<CodeSmell> CodeSmells { get; set; }

    public DbSet<FocusSessionSmell> FocusSessionSmells { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Project>()
            .HasMany(p => p.Commits)
            .WithOne(c => c.Project)
            .HasForeignKey(c => c.ProjectId);

        modelBuilder.Entity<Project>()
            .HasMany(p => p.FocusSessions)
            .WithOne(s => s.Project)
            .HasForeignKey(s => s.ProjectId);
        
        modelBuilder.Entity<Project>()
            .HasMany(p => p.CodeFiles)
            .WithOne(c => c.Project)
            .HasForeignKey(c => c.ProjectId);

        modelBuilder.Entity<CodeFile>()
            .HasMany(c => c.Smells)
            .WithOne(s => s.CodeFile)
            .HasForeignKey(s => s.CodeFileId);

        modelBuilder.Entity<FocusSessionSmell>()
            .HasKey(fss => new { fss.FocusSessionId, fss.CodeSmellId });

        modelBuilder.Entity<FocusSessionSmell>()
            .HasOne(fss => fss.FocusSession)
            .WithMany(fs => fs.TargetSmells)
            .HasForeignKey(fss => fss.FocusSessionId);

        modelBuilder.Entity<FocusSessionSmell>()
            .HasOne(fss => fss.CodeSmell)
            .WithMany(cs => cs.FocusSessions)
            .HasForeignKey(fss => fss.CodeSmellId);
    }
}
