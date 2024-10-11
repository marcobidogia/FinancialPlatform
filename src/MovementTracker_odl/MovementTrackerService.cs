using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Storage.contexts;
using Storage.Entities;
using Storage.Records;
using Storage.Repositories;

namespace MovementTracker;

public class MovementTrackerService(IDbContextFactory<MovementTrackerDbContext> DbContext): IMovementTrackerService, IHostedService
{
    public void AddIncome(IncomeMovement income)
    {
        using var mtDbContext = DbContext.CreateDbContext();
        mtDbContext.IncomeMovements.Add(income);
        
        mtDbContext.SaveChanges();
    }

    public void AddOutcome(OutcomeMovement outcome)
    {
        throw new NotImplementedException();
    }

    public void AddIncomeCategory(IncomeMovementCategory category)
    {
        throw new NotImplementedException();
    }

    public void AddOutcomeCategory(OutcomeMovementCategory category)
    {
        throw new NotImplementedException();
    }

    public List<IncomeMovement> GetIncomes()
    {
        using var mtDbContext = DbContext.CreateDbContext();
        var mtRepo = new MovementTrackerRepository(mtDbContext);

        return mtRepo.GetIncomeMovements();
    }

    public List<OutcomeMovement> GetOutcomes()
    {
        using var mtDbContext = DbContext.CreateDbContext();
        var mtRepo = new MovementTrackerRepository(mtDbContext);

        return mtRepo.GetOutcomeMovements();
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        Debug.WriteLine("Movement Tracker Service Started");
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        Debug.WriteLine("Movement Tracker Service is stopping.");
        return Task.CompletedTask;
    }
}
