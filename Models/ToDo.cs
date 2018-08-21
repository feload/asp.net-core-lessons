using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_lessons.Models
{
  public class ToDo : BaseEntity
  {
    public string Text { get; set; }
    public bool Completed { get; set; }
  }
}