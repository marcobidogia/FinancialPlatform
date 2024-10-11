using System.ComponentModel.DataAnnotations.Schema;

namespace Storage.Records;

[Table("income_movement_category")]
public record IncomeMovementCategory : MovementCategory
{
    
}