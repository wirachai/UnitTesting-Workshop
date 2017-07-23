namespace SampleStub
{
    public interface IUserRepository
    {
        bool IsExist(string username, string password);
    }
}