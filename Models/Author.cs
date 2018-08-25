using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreLessons.Models
{
  public class Author
  {
    [Key]
    [Required]
    public int Id { get; set; }

    // This entity will have a compound key defined with fluid API.
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }

    [NotMapped]
    public string FullName
    {
      get
      {
        return $"{FirstName} {MiddleName} {LastName}";
      }
    }
    public DateTime DateOfBirth { get; set; }
    public string Nationality { get; set; }
    public List<Book> Books { get; set; }
  }
}