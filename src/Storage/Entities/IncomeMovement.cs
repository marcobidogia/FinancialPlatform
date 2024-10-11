using System.ComponentModel.DataAnnotations.Schema;
using Storage.Records;

namespace Storage.Entities;

[Table("income_movements")]
public class IncomeMovement : Movement
{
    [Column("category")]
    public IncomeMovementCategory Category { get; set; } = new IncomeMovementCategory();
}