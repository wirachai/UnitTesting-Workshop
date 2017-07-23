namespace WorkshopMock.Repositories
{
    public class AccountRepository
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