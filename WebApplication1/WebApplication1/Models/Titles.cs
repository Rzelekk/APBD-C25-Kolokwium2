﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("titles")]
public class Titles
{
    [Key]
    public int Id { get; set; }
    [MaxLength(100)] 
    public string Name { get; set; }
    
    public ICollection<CharacterTitles> CharacterTitles { get; set; } = new HashSet<CharacterTitles>();
}