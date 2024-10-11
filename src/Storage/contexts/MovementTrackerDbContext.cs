using Microsoft.EntityFrameworkCore;
using Storage.Entities;

namespace Storage.contexts;

public class MovementTrackerDbContext(DbContextOptions<MovementTrackerDbContext> options) : DbContext(options)
{
    public DbSet<IncomeMovement> IncomeMovements { get; set; }
    public DbSet<OutcomeMovement> OutcomeMovements { get; set; }
}