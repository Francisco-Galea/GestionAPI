using GestionAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GestionAPI.API.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController 
    {
        [HttpGet]
        public List<ProductEntity> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public string GetProductById(int id)
        {
            return "value";
        }

        [HttpPost]
        public void PostProduct([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void UpdateProduct(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void DeleteProduct(int id)
        {
        }
    }
}
