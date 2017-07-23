namespace WorkshopMock.Repositories
{
    public class AccountRepository : WorkshopMock.Repositories.IAccountRepository
    {
        public decimal GetBalance(string accountId)
        {
            // fake result
            return 100;
        }

        public void Edit(string accountId, decimal money)
        {
        }
    }
}