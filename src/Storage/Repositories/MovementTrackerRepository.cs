using Storage.contexts;
using Storage.Entities;
using Storage.Interfaces;
using Storage.Records;

namespace Storage.Repositories;

public class MovementTrackerRepository(MovementTrackerDbContext context): IMovementTrackerRepository 
{
    public IncomeMovement GetIncomeMovement(int incomeId)
    {
        return context.IncomeMovements.Find(incomeId) ?? throw new KeyNotFoundException();
    }

    public List<IncomeMovement> GetIncomeMovements()
    {
        return context.IncomeMovements.ToList();
    }
    
    public void AddIncomeMovement(IncomeMovement incomeMovement)
    {
        context.IncomeMovements.Add(incomeMovement);
        context.SaveChanges();
    }
    
    public void UpdateIncomeMovement(IncomeMovement incomeMovement)
    {
        context.IncomeMovements.Update(incomeMovement);
        context.SaveChanges();
    }
    
    public void DeleteIncomeMovement(IncomeMovement incomeMovement)
    {
        context.IncomeMovements.Remove(incomeMovement);
        context.SaveChanges();
    }

    public OutcomeMovement GetOutcomeMovement(int outcomeId)
    {
        return context.OutcomeMovements.Find(outcomeId) ?? throw new KeyNotFoundException();
    }

    public List<OutcomeMovement> GetOutcomeMovements()
    {
        return context.OutcomeMovements.ToList();
    }

    public void AddOutcomeMovement(OutcomeMovement outcomeMovement)
    {
        context.OutcomeMovements.Add(outcomeMovement);
        context.SaveChanges();
    }

    public void UpdateOutcomeMovement(OutcomeMovement outcomeMovement)
    {
        context.OutcomeMovements.Update(outcomeMovement);
        context.SaveChanges();
    }

    public void DeleteOutcomeMovement(OutcomeMovement outcomeMovement)
    {
        context.OutcomeMovements.Remove(outcomeMovement);
        context.SaveChanges();
    }
}