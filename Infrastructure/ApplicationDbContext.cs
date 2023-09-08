using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Task = Domain.Entities.Task;

namespace Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) 
        : base(options)
    { }
    
    public required DbSet<Task> Tasks { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}