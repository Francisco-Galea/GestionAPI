using GestionAPI.BlazorUI.Models.DTOs.Request;
using GestionAPI.BlazorUI.Models.DTOs.Response;

namespace GestionAPI.BlazorUI.Services.Interfaces
{
    public interface IProductService
    {
        Task CreateProduct(ProductRequest productRequest);
        Task<List<ProductResponse>> GetAllProducts();
        Task<ProductResponse> GetProductById(int productId);
        Task DeleteProduct(int productId);
        Task UpdateProduct(int productId, ProductResponse product);
    }
}
