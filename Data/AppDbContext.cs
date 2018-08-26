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
    public DbSet<Client> Clients { get; set; }
    public DbSet<Membership> Memberships { get; set; }
    public DbSet<PersonalLibrary> PersonalLibraries { get; set; }
    public DbSet<PersonalLibraryBook> PersonalLibraryBooks { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Blog> Blogs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      // This is another approach to set a field properties through ASP net core fluent API.
      // Unlike data annotations, this approach is a bit more verbose.

      modelBuilder
        .Entity<Book>()
        .Property(b => b.Isbn)
        .HasMaxLength(10);

      // Define unique fields.

      modelBuilder
        .Entity<Book>()
        .HasIndex(b => b.Isbn)
        .HasName("UniqueIsbn")
        .IsUnique();

      modelBuilder
        .Entity<Book>()
        .Ignore(b => b.FullTitle);

      modelBuilder
        .Entity<Book>()
        .Property(b => b.CreatedAt)
        .HasDefaultValueSql("getdate()");

      modelBuilder
        .Entity<Book>()
        .HasOne(b => b.Author)
        .WithMany(a => a.Books)
        .HasForeignKey(b => b.AuthorId);

      // This is how you define a compound key.
      // modelBuilder.Entity<Author>().HasKey(a => new { a.FirstName, a.LastName });

      // Client - Personal Library one-to-one relationship.
      modelBuilder
        .Entity<Client>()
        .HasOne(c => c.Library)
        .WithOne(l => l.Client)
        .HasForeignKey<PersonalLibrary>();

      // It's important to know that many-to-many relationships can only be done with fluent API.
      modelBuilder
        .Entity<PersonalLibraryBook>()
        .HasKey(pl => new { pl.BookId, pl.LibraryId });

      // Book - PersonalLibrary many-to-many relationship.
      modelBuilder
        .Entity<PersonalLibraryBook>()
        .HasOne(pl => pl.Book)
        .WithMany(b => b.PersonalLibraryBooks)
        .HasForeignKey(pl => pl.BookId);

      modelBuilder
        .Entity<PersonalLibraryBook>()
        .HasOne(pl => pl.PersonalLibrary)
        .WithMany(l => l.PersonalLibraryBooks)
        .HasForeignKey(pl => pl.LibraryId);

    }
  }
}