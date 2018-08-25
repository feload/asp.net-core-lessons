using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreLessons.Models
{
  public class Book : BaseEntity
  {
    [Required]
    [MaxLength(32)]
    public string Title { get; set; }

    [Required]
    public string Author { get; set; }

    [Required]
    public string Isbn { get; set; }
  }
}