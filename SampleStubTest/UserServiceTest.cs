using Moq;
using NUnit.Framework;
using SampleStub;
using SampleStub.Models;

namespace SampleStubTest
{
    [TestFixture]
    public class UserServiceTest
    {
        private string validUser = "username";
        private string validPass = "password";

        [Test]
        public void IsValidLogin_ShouldReturnTrue_WhenExistAccount()
        {
            // arrange
            var mock = new Mock<IUserRepository>();
            mock.Setup(x => x.IsExist(validUser, validPass)).Returns(true);

            UserService service = new UserService();
            service.UserRepository = mock.Object;

            // act
            LoginModel model = new LoginModel() { Username = validUser, Password = validPass };
            bool result = service.IsValidLogin(model);

            // assert
            Assert.AreEqual(true, result);
        }
    }
}