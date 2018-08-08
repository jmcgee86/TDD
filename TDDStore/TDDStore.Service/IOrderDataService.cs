using System;

namespace TDDStore.Service
{
    public interface IOrderDataService
    {
        Guid Save(Order order);
    }
}