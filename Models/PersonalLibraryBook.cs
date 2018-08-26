using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreLessons.Models
{
  public class PersonalLibraryBook
  {
    public int BookId { get; set; }
    public Book Book { get; set; }

    public int LibraryId { get; set; }
    public PersonalLibrary PersonalLibrary { get; set; }
  }
}