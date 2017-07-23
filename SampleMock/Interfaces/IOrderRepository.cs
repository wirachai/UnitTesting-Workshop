using SampleMock.Models;
using System.Collections.Generic;

namespace SampleMock.Interfaces
{
    public interface IOrderRepository
    {
        void Add(List<OrderItemModel> items);
    }
}