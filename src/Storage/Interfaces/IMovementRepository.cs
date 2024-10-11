using Microsoft.VisualBasic;
using Storage.Entities;
using Storage.Records;

namespace Storage.Interfaces;

public interface IMovementTrackerRepository
{
    public IncomeMovement GetIncomeMovement(int incomeId);
    public List<IncomeMovement> GetIncomeMovements();
    
    public OutcomeMovement GetOutcomeMovement(int outcomeId);
    public List<OutcomeMovement> GetOutcomeMovements();
    
    public IncomeMovementCategory GetIncomeMovementCategory(int incomeId);
    public List<IncomeMovementCategory> GetIncomeMovementCategoryList();
    
    public OutcomeMovementCategory GetOutcomeMovementCategory(int outcomeId);
    public List<OutcomeMovementCategory> GetOutcomeMovementCategoryList();
}