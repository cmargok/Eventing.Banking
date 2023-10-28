using Banking.Application.Models;
using Banking.Domain.Events;
using Banking.Domain.Models;

namespace Banking.Application.interfaces
{
    public interface IAccountService
    {
        public IEnumerable<Account> GetAccounts();

        public void Transfer(AccountTransfer accountTransfer);
    }
}
