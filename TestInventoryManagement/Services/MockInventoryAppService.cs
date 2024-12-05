using System.Reactive.Subjects;
using InventoryManagement.Models.InventoryApp;

namespace InventoryManagement.InventoryApp
{
    public class MockInventoryAppService : IInventoryAppService
    {
        public BehaviorSubject<List<ProductsType>> Products { get; } = new(new());

        public Task<List<NewProductsType>> GetNewProductsList()
        {
            return Task.FromResult<List<NewProductsType>>(new());
        }

        public Task<List<ProductsType>> GetProductsList()
        {
            return Task.FromResult<List<ProductsType>>(new());
        }
    }
}
