using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CmsDbEFCodeFirst.Models
{
    public class Konto
    {
        public int Id { get; set; }


        [StringLength(10)]
        public string Kontonummer { get; set; }

        public decimal Saldo { get; set; }

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}