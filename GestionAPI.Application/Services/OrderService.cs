using GestionAPI.Application.DTOs.Request;
using GestionAPI.Application.Interfaces.IRepository;
using GestionAPI.Application.Interfaces.IService;
using GestionAPI.Domain.Entities;

namespace GestionAPI.Application.Services
{
    public class OrderService : IOrderService
    { 

        private readonly IOrderRepository orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public async Task CreateOrder(OrderRequest orderRequest)
        {
            OrderEntity orderEntity = new OrderEntity()
            {
                ClientId = orderRequest.ClientId,
            };
            await orderRepository.InsertAsync(orderEntity);
        }

        public Task DeleteOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderEntity>> GetAllOrders()
        {
            return await orderRepository.GetAllAsync();
        }

        public async Task<OrderEntity> GetOrderById(int orderId)
        {
            return await orderRepository.GetByIdAsync(orderId);
        }

        public async Task UpdateOrder(int orderId, OrderRequest orderRequest)
        {
            OrderEntity orderEntity = new OrderEntity()
            {
                OrderId = orderId,
                ClientId = orderRequest.ClientId,
            };
            await orderRepository.UpdateAsync(orderEntity);
        }
    }
}
