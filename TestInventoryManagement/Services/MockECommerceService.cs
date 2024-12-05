using System.Reactive.Subjects;
using InventoryManagement.Models.ECommerce;

namespace InventoryManagement.ECommerce
{
    public class MockECommerceService : IECommerceService
    {
        public BehaviorSubject<List<RevenueType>> Revenue { get; } = new(new());

        public Task<List<SalesType>> GetSalesList()
        {
            return Task.FromResult<List<SalesType>>(new());
        }

        public Task<List<RevenueType>> GetRevenueList()
        {
            return Task.FromResult<List<RevenueType>>(new());
        }
    }
}
