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
            var mockRepo = new AccountRepository_Mock();
            mockRepo.Balance = 100;

            var service = new BankAccountService(mockRepo);

            // act
            service.Withdraw("someid", 100);

            // assert
            Assert.AreEqual(true, mockRepo.IsSaved);
        }

        [Test]
        public void Withdraw_ShouldSave_WhenWithdrawLessThanBalance()
        {
            // arrange
            var mockRepo = new AccountRepository_Mock();
            mockRepo.Balance = 500;

            var service = new BankAccountService(mockRepo);

            // act
            service.Withdraw("someid", 200);

            // assert
            Assert.AreEqual(true, mockRepo.IsSaved);
        }

        [Test]
        public void Withdraw_ShouldNotSave_WhenWithdrawGreaterThanBalance()
        {
            // arrange
            var mockRepo = new AccountRepository_Mock();
            mockRepo.Balance = 500;

            var service = new BankAccountService(mockRepo);

            // act
            service.Withdraw("someid", 1000);

            // assert
            Assert.AreEqual(false, mockRepo.IsSaved);
        }
    }
}