using SampleMock.Interfaces;
using SampleMock.Models;
using System.Collections.Generic;

namespace SampleMock.Repositories
{
    public class OrderRepository_Mock : IOrderRepository
    {
        public bool IsSaved { get; set; }

        public void Add(List<OrderItemModel> items)
        {
            IsSaved = true;
        }
    }
}