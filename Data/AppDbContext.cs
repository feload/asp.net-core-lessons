using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions;
using ASPNetCoreLessons.Models;

namespace ASPNetCoreLessons.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<ToDo> ToDos { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder ModelBuilder) 
    {
      // This is another approach to set a field properties through ASP net core fluent API.
      // Unlike data annotations, this approach is a bit more verbose.
      ModelBuilder.Entity<Book>().Property(b => b.Isbn).HasMaxLength(10);
    }
  }
}