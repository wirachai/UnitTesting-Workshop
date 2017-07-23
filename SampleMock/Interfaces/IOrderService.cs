using SampleMock.Models;
using System.Collections.Generic;

namespace SampleMock.Interfaces
{
    public interface IOrderService
    {
        void Create(List<OrderItemModel> items);
    }
}