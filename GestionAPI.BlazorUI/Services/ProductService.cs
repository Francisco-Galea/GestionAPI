using GestionAPI.BlazorUI.Models.DTOs.Request;
using GestionAPI.BlazorUI.Models.DTOs.Response;
using GestionAPI.BlazorUI.Services.Interfaces;

namespace GestionAPI.BlazorUI.Services
{
    public class ProductService : IProductService
    {

        private readonly HttpClient httpClient;

        public ProductService(IHttpClientFactory httpClientFactory)
        {
            this.httpClient = httpClientFactory.CreateClient("GestionAPI");
        }

        public Task CreateProduct(ProductRequest productRequest)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductResponse>> GetAllProducts()
        {
            List<ProductResponse> products = new List<ProductResponse>();
            products = await httpClient.GetFromJsonAsync<List<ProductResponse>>("api/products");
            return products;
        }

        public Task<ProductResponse> GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProduct(int productId, ProductResponse product)
        {
            throw new NotImplementedException();
        }
    }
}
