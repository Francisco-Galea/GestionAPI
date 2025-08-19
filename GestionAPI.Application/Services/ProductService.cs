using GestionAPI.Application.DTOs.Request;
using GestionAPI.Application.Interfaces.IRepository;
using GestionAPI.Application.Interfaces.IService;
using GestionAPI.Domain.Entities;

namespace GestionAPI.Application.Services
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository repository;

        public ProductService(IProductRepository repository)
        {
            this.repository = repository;
        }

        public async Task CreateProduct(ProductRequest productRequest)
        {
            ProductEntity product = new ProductEntity() { 
                ProductName = productRequest.ProductName, 
                ProductPrice = productRequest.ProductPrice
            };
            await repository.InsertAsync(product);
        }

        public Task DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductEntity>> GetAllProducts()
        {
            return await repository.GetAllAsync();
        }

        public async Task<ProductEntity> GetProductById(int productId)
        {
            return await repository.GetByIdAsync(productId);
        }

        public async Task UpdateProduct(int productId, ProductRequest productRequest)
        {
            ProductEntity product = new ProductEntity() {  
                ProductId = productId, 
                ProductName = productRequest.ProductName, 
                ProductPrice = productRequest.ProductPrice 
            };
            await repository.UpdateAsync(product);
        }
    }
}
