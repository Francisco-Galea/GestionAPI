using GestionAPI.Application.DTOs.Request;
using GestionAPI.Application.Interfaces.IService;
using GestionAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GestionAPI.API.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<List<ProductEntity>> GetAllProducts()
        {
            return await productService.GetAllProducts();
        }

        [HttpGet("{id}")]
        public async Task<ProductEntity> GetProductById(int productId)
        {
            return await productService.GetProductById(productId);
        }

        [HttpPost]
        public async Task PostProduct([FromBody] ProductRequest product)
        {
            await productService.CreateProduct(product);
        }

        [HttpPut("{id}")]
        public async void UpdateProduct(int productId, [FromBody] ProductRequest productRequest)
        {
            await productService.UpdateProduct(productId, productRequest);
        }

        [HttpDelete("{id}")]
        public async void DeleteProduct(int productId)
        {
            await productService.DeleteProduct(productId);
        }

    }
}
