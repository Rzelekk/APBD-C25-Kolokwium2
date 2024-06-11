using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("character")]
public class Characters
{
    [Key]
    public int Id { get; set; }
    [MaxLength(50)]
    public string FirstName { get; set; }
    [MaxLength(120)]
    public string LastName { get; set; }
    public int CurrentWei { get; set; }
    public int MaxWeight { get; set; }
}