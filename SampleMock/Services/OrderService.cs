using SampleMock.Interfaces;
using SampleMock.Models;
using System.Collections.Generic;

namespace SampleMock.Services
{
    public class OrderService : IOrderService
    {
        public IOrderRepository OrderRepository { get; set; }
        public IValidator CreateValidator { get; set; }

        public void Create(List<OrderItemModel> items)
        {
            CreateValidator.Validate();
            if (CreateValidator.IsValid)
            {
                OrderRepository.Add(items);
            }
        }
    }
}