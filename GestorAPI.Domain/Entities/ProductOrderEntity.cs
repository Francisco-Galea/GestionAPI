
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionAPI.Domain.Entities
{
    public class ProductOrderEntity
    {
        [Key]
        public int ProductOrderId { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public ProductEntity Product { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public OrderEntity Order { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitaryPrice { get; set; }

        public bool IsOrderActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
