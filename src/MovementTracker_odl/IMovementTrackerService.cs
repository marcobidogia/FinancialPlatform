using System.Runtime.CompilerServices;
using Storage.Entities;
using Storage.Records;

namespace MovementTracker;

public interface IMovementTrackerService
{
    public void AddIncome(IncomeMovement income);
    public void AddOutcome(OutcomeMovement outcome);
    public void AddIncomeCategory(IncomeMovementCategory category);
    public void AddOutcomeCategory(OutcomeMovementCategory category);
    public List<IncomeMovement> GetIncomes();
    public List<OutcomeMovement> GetOutcomes();
}