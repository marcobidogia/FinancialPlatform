using System.ComponentModel.DataAnnotations.Schema;

namespace Storage.Records;

[Table("income_movement_categories")]
public record IncomeMovementCategory : MovementCategory
{
    
}