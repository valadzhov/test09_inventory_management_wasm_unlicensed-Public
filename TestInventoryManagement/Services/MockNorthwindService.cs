using InventoryManagement.Models.Northwind;

namespace InventoryManagement.Northwind
{
    public class MockNorthwindService : INorthwindService
    {
        public Task<List<OrdersType>> GetOrders()
        {
            return Task.FromResult<List<OrdersType>>(new());
        }
    }
}
