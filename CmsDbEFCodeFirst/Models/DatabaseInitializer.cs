using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CmsDbEFCodeFirst.Models
{
    public class DatabaseInitializer
    {
        public void Initialize(BankDbContext dbContext)
        {
            dbContext.Database.Migrate();
            SeedLaens(dbContext);
        }

        private void SeedLaens(BankDbContext dbContext)
        {
            if (!dbContext.Lan.Any(l => l.Name == "Stockholm"))
            {
                dbContext.Lan.Add(new Lan {Name = "Stockholm"});
            }
            if (!dbContext.Lan.Any(l => l.Name == "Uppsala"))
            {
                dbContext.Lan.Add(new Lan { Name = "Uppsala" });
            }
            if (!dbContext.Lan.Any(l => l.Name == "Dalarna"))
            {
                dbContext.Lan.Add(new Lan { Name = "Dalarna" });
            }

            dbContext.SaveChanges();


        }
    }
}