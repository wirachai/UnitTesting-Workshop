using WorkshopMock.Repositories;

namespace WorkshopMock.Services
{
    public class BankAccountService
    {
        public AccountRepository AccountRepository { get; set; }

        public BankAccountService()
        {
            AccountRepository = new AccountRepository();
        }

        public BankAccountService(AccountRepository repo)
        {
            AccountRepository = repo;
        }

        public void Withdraw(string accountId, decimal money)
        {
            var balance = AccountRepository.GetBalance(accountId);
            if (balance >= money)
            {
                AccountRepository.Edit(accountId, balance - money);
            }
        }
    }
}