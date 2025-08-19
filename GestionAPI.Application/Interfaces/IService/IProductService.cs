using GestionAPI.Application.DTOs.Request;
using GestionAPI.Domain.Entities;

namespace GestionAPI.Application.Interfaces.IService
{
    public interface IProductService
    {
        Task CreateProduct(ProductRequest productRequest);
        Task UpdateProduct(int productId, ProductRequest productRequest);
        Task<ProductEntity> GetProductById(int productId);
        Task<List<ProductEntity>> GetAllProducts();
        Task DeleteProduct(int productId);
    }
}
