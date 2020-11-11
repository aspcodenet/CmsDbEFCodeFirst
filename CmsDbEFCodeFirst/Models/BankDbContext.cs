using Microsoft.EntityFrameworkCore;

namespace CmsDbEFCodeFirst.Models
{
    public class BankDbContext : DbContext
    {
        public BankDbContext()
        {
        }

        public BankDbContext(DbContextOptions<BankDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=BankDbDemo;Trusted_Connection=True;");
            }
        }

        public DbSet<Lan> Lan { get; set; }
        public DbSet<BankWorker> BankWorkers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Konto> Konton { get; set; }
        public DbSet<Person> Personer { get; set; }
    }
}