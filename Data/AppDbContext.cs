using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions;
using asp.net_core_lessons.Models;

namespace asp.net_core_lessons.Data
{
  public class AppDbContext : DbContext
  {
    AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<ToDo> Todos { get; set; }
  }
}