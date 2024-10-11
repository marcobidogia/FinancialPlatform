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

    public OutcomeMovement GetOutcomeMovement(int outcomeId)
    {
        return context.OutcomeMovements.Find(outcomeId) ?? throw new KeyNotFoundException();
    }

    public List<OutcomeMovement> GetOutcomeMovements()
    {
        return context.OutcomeMovements.ToList();
    }

    public IncomeMovementCategory GetIncomeMovementCategory(int incomeId)
    {
        return context.IncomeMovementCategories.Find(incomeId) ?? throw new KeyNotFoundException();
    }

    public List<IncomeMovementCategory> GetIncomeMovementCategoryList()
    {
        return context.IncomeMovementCategories.ToList();
    }

    public OutcomeMovementCategory GetOutcomeMovementCategory(int outcomeId)
    {
        return context.OutcomeMovementCategories.Find(outcomeId) ?? throw new KeyNotFoundException();
    }

    public List<OutcomeMovementCategory> GetOutcomeMovementCategoryList()
    {
        return context.OutcomeMovementCategories.ToList();
    }
}