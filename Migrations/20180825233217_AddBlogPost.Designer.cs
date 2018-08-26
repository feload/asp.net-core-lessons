﻿// <auto-generated />
using System;
using ASPNetCoreLessons.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASPNetCoreLessons.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180825233217_AddBlogPost")]
    partial class AddBlogPost
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASPNetCoreLessons.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Nationality");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("ASPNetCoreLessons.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("ASPNetCoreLessons.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("Isbn")
                        .IsUnique()
                        .HasName("UniqueIsbn");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("ASPNetCoreLessons.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("ASPNetCoreLessons.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("StreetName");

                    b.Property<string>("StreetNumber");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ASPNetCoreLessons.Models.Membership", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<int>("Genre");

                    b.Property<DateTime>("Initiated");

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("Memberships");
                });

            modelBuilder.Entity("ASPNetCoreLessons.Models.PersonalLibrary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<DateTime>("CreatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("PersonalLibraries");
                });

            modelBuilder.Entity("ASPNetCoreLessons.Models.PersonalLibraryBook", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("LibraryId");

                    b.HasKey("BookId", "LibraryId");

                    b.HasIndex("LibraryId");

                    b.ToTable("PersonalLibraryBooks");
                });

            modelBuilder.Entity("ASPNetCoreLessons.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId");

                    b.Property<string>("Content");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("ASPNetCoreLessons.Models.ToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Completed");

                    b.Property<DateTime>("CompletedAt");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.Property<DateTime>("createdAt");

                    b.HasKey("Id");

                    b.ToTable("ToDos");
                });

            modelBuilder.Entity("ASPNetCoreLessons.Models.Book", b =>
                {
                    b.HasOne("ASPNetCoreLessons.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPNetCoreLessons.Models.Membership", b =>
                {
                    b.HasOne("ASPNetCoreLessons.Models.Client", "Client")
                        .WithOne("Membership")
                        .HasForeignKey("ASPNetCoreLessons.Models.Membership", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPNetCoreLessons.Models.PersonalLibrary", b =>
                {
                    b.HasOne("ASPNetCoreLessons.Models.Client", "Client")
                        .WithOne("Library")
                        .HasForeignKey("ASPNetCoreLessons.Models.PersonalLibrary", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPNetCoreLessons.Models.PersonalLibraryBook", b =>
                {
                    b.HasOne("ASPNetCoreLessons.Models.Book", "Book")
                        .WithMany("PersonalLibraryBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ASPNetCoreLessons.Models.PersonalLibrary", "PersonalLibrary")
                        .WithMany("PersonalLibraryBooks")
                        .HasForeignKey("LibraryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPNetCoreLessons.Models.Post", b =>
                {
                    b.HasOne("ASPNetCoreLessons.Models.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
