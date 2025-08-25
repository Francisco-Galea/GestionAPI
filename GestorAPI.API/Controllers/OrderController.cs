using GestionAPI.Application.DTOs.Request;
using GestionAPI.Application.Interfaces.IService;
using GestionAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GestionAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpPost]
        public async Task CreateOrder([FromBody] OrderRequest orderRequest)
        {
        }

        [HttpPut("{orderId}")]
        public async Task UpdateOrder(int orderId, [FromBody] OrderRequest orderRequest)
        {
        }

        [HttpGet("{orderId}")]
        public async Task<OrderEntity> GetOrderById(int orderId)
        {
            return await orderService.GetOrderById(orderId);
        }

        [HttpGet]
        public async Task<List<OrderEntity>> GetAllOrders()
        {
            return await orderService.GetAllOrders();
        }

        [HttpPut]
        public async Task EndOrder()
        {

        }

        [HttpDelete]
        public async Task DeleteOrder()
        {

        }



    }
}
