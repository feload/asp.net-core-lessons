using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_lessons.Models
{
  public class Contact : BaseEntity
  {
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string Email { get; set; }

    public string PhoneNumber { get; set; }
    public string StreetName { get; set; }
    public string StreetNumber { get; set; }
  }
}