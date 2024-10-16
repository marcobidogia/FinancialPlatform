using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Storage.Records;

public abstract record MovementCategory
{
    [Key, Column("id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    [Column("name")]
    public string Name { get; init; } = string.Empty;
}