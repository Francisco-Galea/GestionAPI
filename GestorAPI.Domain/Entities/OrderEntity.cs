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

        public bool IsDeleted { get; set; } = false;

        public ICollection<ProductOrderEntity> ProductOrders { get; set; } = new List<ProductOrderEntity>();
    }
}
