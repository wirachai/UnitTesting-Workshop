using NUnit.Framework;
using SampleMock.Models;
using SampleMock.Repositories;
using SampleMock.Services;
using SampleMock.Validators;
using System.Collections.Generic;

namespace SampleMock.Test
{
    [TestFixture]
    internal class OrderServiceTest
    {
        [Test]
        public void Create_ShouldSave_WhenValidValidation()
        {
            // arrange
            Validator_Stub stubValidator = new Validator_Stub();
            stubValidator.IsValid = true;

            OrderRepository_Mock mockRepository = new OrderRepository_Mock();

            OrderService service = new OrderService();
            service.CreateValidator = stubValidator;
            service.OrderRepository = mockRepository;

            // act
            List<OrderItemModel> testData = new List<OrderItemModel>();
            testData.Add(new OrderItemModel() { ItemId = "ITM0001", Quantity = 1 });

            service.Create(testData);
            bool result = mockRepository.IsSaved;

            // assert
            Assert.AreEqual(true, result);
        }
    }
}