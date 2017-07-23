using SampleStub.Models;

namespace SampleStub
{
    public class UserService
    {
        public IUserRepository UserRepository { get; set; }

        public bool IsValidLogin(LoginModel model)
        {
            // some validation

            return UserRepository.IsExist(model.Username, model.Password);
        }
    }
}