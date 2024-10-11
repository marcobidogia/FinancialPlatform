using Microsoft.EntityFrameworkCore;
using Storage.Entities;
using Storage.Records;

namespace Storage.contexts;

public class MovementTrackerDbContext(DbContextOptions<MovementTrackerDbContext> options) : DbContext(options)
{
    public DbSet<IncomeMovement> IncomeMovements { get; set; }
    public DbSet<OutcomeMovement> OutcomeMovements { get; set; }
    
    
    public DbSet<IncomeMovementCategory> IncomeMovementCategories { get; set; }
    public DbSet<OutcomeMovementCategory> OutcomeMovementCategories { get; set; }
}