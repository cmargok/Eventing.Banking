using Banking.Application.interfaces;
using Banking.Domain.Interfaces;
using Banking.Domain.Models;

namespace Banking.Application.services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public IEnumerable<Account> GetAccounts()
        {
           return _accountRepository.GetAccounts();
        }
    }
}
