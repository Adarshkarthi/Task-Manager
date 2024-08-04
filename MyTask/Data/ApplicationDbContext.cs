using Microsoft.EntityFrameworkCore;
using MyTask.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<MyTasks> Tasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure entity properties and relationships here
        modelBuilder.Entity<MyTasks>()
            .HasKey(t => t.Id); // Ensure that Id is the primary key

        // Other configurations can go here
    }
}
