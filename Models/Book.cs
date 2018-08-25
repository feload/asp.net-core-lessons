using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreLessons.Models
{
  public class Book : BaseEntity
  {
    // Use [Key] attribute to set a field as a key id.
    // [key]
    // public string BookIdentifier { get; set; }

    [Required]
    [MaxLength(32)]
    public string Title { get; set; }

    [Required]
    public string Author { get; set; }

    [Required]
    public string Isbn { get; set; }
    public string FullTitle
    {
      get
      {
        return $"{Author}'s {Title}";
      }
    }

    /*
      Strategies:
        None: No generation takes place.
        Identity: Field will be filled only when row is inserted.
        Computed: Field will be updated every time the row updates.
    */
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }
  }
}