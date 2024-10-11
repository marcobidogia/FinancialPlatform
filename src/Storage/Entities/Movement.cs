using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Storage.Entities;

public abstract class Movement
{
    [Key, Column("id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column("date")]
    public DateTime Date { get; set; } = DateTime.Now;
    
    [Column("amount")]
    public decimal Amount { get; set; }
    
    [Column("notes")]
    public string Notes = string.Empty;
}