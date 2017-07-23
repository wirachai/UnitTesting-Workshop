using Moq;
using NUnit.Framework;
using WorkshopMock.Repositories;
using WorkshopMock.Services;

namespace WorkshopMock.Test
{
    [TestFixture]
    internal class BankAccountServiceTest
    {
        [Test]
        public void Withdraw_ShouldSave_WhenWithdrawEqualBalance()
        {
            // arrange
            var mockRepo = CreateMockWithBalance(100);
            var service = new BankAccountService(mockRepo.Object);

            // act
            service.Withdraw("someid", 100);

            // assert
            mockRepo.Verify(x => x.Edit("someid", 0), Times.Once);
        }

        [Test]
        public void Withdraw_ShouldSave_WhenWithdrawLessThanBalance()
        {
            // arrange
            var mockRepo = CreateMockWithBalance(500);
            var service = new BankAccountService(mockRepo.Object);

            // act
            service.Withdraw("someid", 200);

            // assert
            mockRepo.Verify(x => x.Edit("someid", 500 - 200), Times.Once);
        }

        [Test]
        public void Withdraw_ShouldNotSave_WhenWithdrawGreaterThanBalance()
        {
            // arrange
            var mockRepo = CreateMockWithBalance(500);
            var service = new BankAccountService(mockRepo.Object);

            // act
            service.Withdraw("someid", 1000);

            // assert
            mockRepo.Verify(x => x.Edit("someid", 500 - 1000), Times.Never);
        }

        private Mock<IAccountRepository> CreateMockWithBalance(decimal balance)
        {
            var mockRepo = new Mock<IAccountRepository>();
            mockRepo.Setup(x => x.GetBalance("someid"))
                .Returns(balance);
            return mockRepo;
        }
    }
}