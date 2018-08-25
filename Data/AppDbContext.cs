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
    public DbSet<Author> Authors { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {
      // This is another approach to set a field properties through ASP net core fluent API.
      // Unlike data annotations, this approach is a bit more verbose.
      modelBuilder.Entity<Book>().Property(b => b.Isbn).HasMaxLength(10);

      // Define unique fields.
      modelBuilder.Entity<Book>().HasIndex(b => b.Isbn).HasName("UniqueIsbn").IsUnique();

      // This is how you define a compound key.
      modelBuilder.Entity<Author>().HasKey(a => new { a.FirstName, a.LastName });
    }
  }
}