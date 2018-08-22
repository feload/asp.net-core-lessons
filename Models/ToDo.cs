using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_lessons.Models
{
  public class ToDo : BaseEntity
  {
    [Required]
    public string Text { get; set; }
    [Required]
    public bool Completed { get; set; }
    [Required]
    public DateTime createdAt { get; set; }
    public DateTime CompletedAt { get; set; }
  }
}