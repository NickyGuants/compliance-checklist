using Microsoft.EntityFrameworkCore;

namespace CompChecklistAPI.Models;

public class CompContext: DbContext{
    public CompContext(DbContextOptions<CompContext> options): 
    base(options)
    {

    }
    public DbSet<ComplianceTask> ComplianceTasks { get; set; } = null!;
}