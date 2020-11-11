using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using CmsDbEFCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace CmsDbEFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new BankDbContext())
            {
                context.Database.Migrate();
            }

            using (var context = new BankDbContext())
            {
                var person = new Person
                {
                    AntalBilar = 1,
                    Birthdate = new DateTime(1972, 8, 3),
                    Name = "Stefan"
                };
                person.Konton.Add(new Konto { Kontonummer = "12345", Saldo = 12 });
                person.Konton.Add(new Konto { Kontonummer = "3333333", Saldo = 102 });
                context.Personer.Add(person);
                context.SaveChanges();
                //var p = context.Personer.FirstOrDefault(r=>r.Name == "Stefan");
            }

        }
    }
}
