using SampleMock.Interfaces;
using System.Collections.Generic;

namespace SampleMock.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public void Add(List<Models.OrderItemModel> items)
        {
            // save data to database
        }
    }
}