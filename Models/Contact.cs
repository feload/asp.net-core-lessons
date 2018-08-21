using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_lessons.Models
{
  public class Contact : BaseEntity
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
  }
}