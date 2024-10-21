using Microsoft.VisualBasic;
using Storage.Entities;
using Storage.Records;

namespace Storage.Interfaces;

public interface IMovementTrackerRepository
{
    public IncomeMovement GetIncomeMovement(int incomeId);
    public List<IncomeMovement> GetIncomeMovements();
    public void AddIncomeMovement(IncomeMovement incomeMovement);
    public void UpdateIncomeMovement(IncomeMovement incomeMovement);
    public void DeleteIncomeMovement(IncomeMovement incomeMovement);
    public OutcomeMovement GetOutcomeMovement(int outcomeId);
    public List<OutcomeMovement> GetOutcomeMovements();
    public void AddOutcomeMovement(OutcomeMovement outcomeMovement);
    public void UpdateOutcomeMovement(OutcomeMovement outcomeMovement);
    public void DeleteOutcomeMovement(OutcomeMovement outcomeMovement);
}