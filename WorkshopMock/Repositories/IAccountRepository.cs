namespace WorkshopMock.Repositories
{
    public interface IAccountRepository
    {
        void Edit(string accountId, decimal money);

        decimal GetBalance(string accountId);
    }
}