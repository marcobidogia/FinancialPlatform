using Storage.contexts;
using Storage.Entities;
using Storage.Interfaces;

namespace Storage.Repositories;

public class MovementTrackerRepository(MovementTrackerDbContext context): IMovementTrackerRepository 
{
    public IncomeMovement getIncomeMovement(int incomeId)
    {
        return context.IncomeMovements.Find(incomeId) ?? throw new KeyNotFoundException();
    }

    public List<IncomeMovement> getIncomeMovements()
    {
        return context.IncomeMovements.ToList();
    }

    public OutcomeMovement getOutcomeMovement(int outcomeId)
    {
        return context.OutcomeMovements.Find(outcomeId) ?? throw new KeyNotFoundException();
    }

    public List<OutcomeMovement> getOutcomeMovements()
    {
        return context.OutcomeMovements.ToList();
    }
}