using GestionAPI.Application.DTOs.Request;
using GestionAPI.Domain.Entities;

namespace GestionAPI.Application.Interfaces.IService
{
    public interface IOrderService
    {
        Task CreateOrder(OrderRequest orderRequest);
        Task UpdateOrder(int orderId, OrderRequest orderRequest);
        Task<OrderEntity> GetOrderById(int orderId);
        Task<List<OrderEntity>> GetAllOrders(); 
        Task DeleteOrder(int orderId);
    }
}
