using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.net_core_lessons.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions;

namespace asp.net_core_lessons.Data
{
  public static class DbInit
  {
    public static void InitializeWithFakeData(AppDbContext context)
    {
      // It creates the database in case its missing.
      context.Database.EnsureCreated();

      if (!context.Contacts.Any()) {
        context.Contacts.Add(new Contact() {
          FirstName = "John",
          LastName = "Pérez",
          Email = "john@perez.com"
        });

        context.Contacts.Add(new Contact() {
          FirstName = "Jane",
          LastName = "Ruíz",
          Email = "jane@ruiz.com"
        });

        context.Contacts.Add(new Contact() {
          FirstName = "Raúl",
          LastName = "Ortíz",
          Email = "raul@ortiz.com"
        });
      }

      if (!context.ToDos.Any()) {
        context.ToDos.Add(new ToDo() {
          Text = "Buy some milk"
        });

        context.ToDos.Add(new ToDo() {
          Text = "Pay the rent"
        });

        context.ToDos.Add(new ToDo() {
          Text = "Fill the tank"
        });
      }

      context.SaveChanges();
    }
  }
}