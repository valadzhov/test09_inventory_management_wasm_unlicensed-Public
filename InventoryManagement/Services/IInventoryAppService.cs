using System.Reactive.Subjects;
using InventoryManagement.Models.InventoryApp;

namespace InventoryManagement.InventoryApp
{
    public interface IInventoryAppService
    {
        public BehaviorSubject<List<ProductsType>> Products { get; }

        Task<List<NewProductsType>> GetNewProductsList();
        Task<List<ProductsType>> GetProductsList();
    }
}
