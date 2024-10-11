using System.ComponentModel.DataAnnotations.Schema;

namespace Storage.Records;

[Table("outcome_movement_categories")]
public record OutcomeMovementCategory : MovementCategory
{
    
}