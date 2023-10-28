
using Banking.Domain.Interfaces;
using Banking.Domain.Models;
using Banking.Infrastructure.Persistence.Context;

namespace Banking.Infrastructure.Persistence.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDBContext _dbContext;
        public AccountRepository(BankingDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Account> GetAccounts()
        {
            var accounts = _dbContext.Accounts;

            return accounts;
        }
    }
}
