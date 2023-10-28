using Banking.Domain.Models;

namespace Banking.Application.interfaces
{
    public interface IAccountService
    {
        public IEnumerable<Account> GetAccounts();
    }
}
