using System;
using System.Collections.Generic;

namespace CmsDbEFCodeFirst.Models
{
    public class BankWorker
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Person
    {
        public BankWorker BankContact { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

        public string PersonNummer { get; set; }


        public int AntalBilar { get; set; }

        public List<Konto> Konton { get; set; } = new List<Konto>();
    }
}