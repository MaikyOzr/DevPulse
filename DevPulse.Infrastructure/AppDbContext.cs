using DevPulse.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;


namespace DevPulse.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<ProjectModel> Projects { get; set; }

    public DbSet<CommitModel> Commits { get; set; }

    public DbSet<FocusSessionModel> FocusSessions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProjectModel>()
            .HasMany(p => p.Commits)
            .WithOne(c => c.Project)
            .HasForeignKey(c => c.ProjectId);

        modelBuilder.Entity<ProjectModel>()
            .HasMany(p => p.FocusSessions)
            .WithOne(s => s.Project)
            .HasForeignKey(s => s.ProjectId);
    }
}
