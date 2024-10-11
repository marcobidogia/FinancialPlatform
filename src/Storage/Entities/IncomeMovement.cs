using System.ComponentModel.DataAnnotations.Schema;
using Storage.Records;

namespace Storage.Entities;

[Table("income_movement")]
public class IncomeMovement : Movement
{
    // [Column("category")]
    // public IncomeMovementCategory Category { get; set; } = new IncomeMovementCategory();
}