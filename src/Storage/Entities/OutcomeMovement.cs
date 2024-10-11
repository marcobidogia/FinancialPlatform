using System.ComponentModel.DataAnnotations.Schema;
using Storage.Records;

namespace Storage.Entities;

[Table("outcome_movements")]
public class OutcomeMovement : Movement
{
    [Column("category")]
    public OutcomeMovementCategory Category { get; set; } = new OutcomeMovementCategory();
}