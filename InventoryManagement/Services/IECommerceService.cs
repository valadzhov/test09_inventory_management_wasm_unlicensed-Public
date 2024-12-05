using System.Reactive.Subjects;
using InventoryManagement.Models.ECommerce;

namespace InventoryManagement.ECommerce
{
    public interface IECommerceService
    {
        public BehaviorSubject<List<RevenueType>> Revenue { get; }

        Task<List<SalesType>> GetSalesList();
        Task<List<RevenueType>> GetRevenueList();
    }
}
