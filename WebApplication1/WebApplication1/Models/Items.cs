﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("items")]
public class Items
{
    [Key] 
    public int Id { get; set; }
    
    [MaxLength(100)] 
    public string Name { get; set; }
    
    public int Weight { get; set; }
    
}