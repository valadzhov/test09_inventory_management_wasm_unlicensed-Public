using InventoryManagement.Models.Northwind;

namespace InventoryManagement.Northwind
{
    public interface INorthwindService
    {
        Task<List<OrdersType>> GetOrders();
    }
}
