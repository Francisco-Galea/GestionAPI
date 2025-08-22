using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionAPI.Domain.Entities
{
    public class OrderEntity
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime DateOrdered { get; set; } = DateTime.UtcNow;

        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public ClientEntity Client { get; set; }

        public int OrderStateId { get; set; }

        [ForeignKey("OrderStateId")]
        public OrderStateEntity OrderState { get; set; }

        public bool IsDeleted { get; set; } = false;

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public UserEntity CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime DeletedAt { get; set; }

        public ICollection<ProductOrderEntity> ProductOrders { get; set; } = new List<ProductOrderEntity>();

    }
}
