using Microsoft.VisualBasic;
using Storage.Entities;

namespace Storage.Interfaces;

public interface IMovementTrackerRepository
{
    public IncomeMovement getIncomeMovement(int incomeId);
    public List<IncomeMovement> getIncomeMovements();
    
    public OutcomeMovement getOutcomeMovement(int outcomeId);
    public List<OutcomeMovement> getOutcomeMovements();
}