using System.Net.Http.Json;
using System.Reactive.Subjects;
using InventoryManagement.Models.InventoryApp;

namespace InventoryManagement.InventoryApp
{
    public class InventoryAppService: IInventoryAppService
    {
        private readonly HttpClient _http;

        public InventoryAppService(HttpClient http)
        {
            _http = http;
        }

        private BehaviorSubject<List<ProductsType>> products;
        public BehaviorSubject<List<ProductsType>> Products
        {
            get
            {
                if (products == null)
                {
                    products = new(new());
                    Task.Run(async () => products.OnNext(await GetProductsList()));
                }
                return products;
            }
        }

        public async Task<List<NewProductsType>> GetNewProductsList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/4b54e7f8-927a-4a38-e690-08dab79fa5b4", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<NewProductsType>>().ConfigureAwait(false);
            }

            return new List<NewProductsType>();
        }

        public async Task<List<ProductsType>> GetProductsList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/22b3aaa8-bba3-43cb-e68f-08dab79fa5b4", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<ProductsType>>().ConfigureAwait(false);
            }

            return new List<ProductsType>();
        }
    }
}
