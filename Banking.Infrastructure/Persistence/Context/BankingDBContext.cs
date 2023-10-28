using Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Banking.Infrastructure.Persistence.Context
{
    public class BankingDBContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public BankingDBContext(DbContextOptions options) : base(options) 
        {
            
        }
    }
}
