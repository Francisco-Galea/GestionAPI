
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionAPI.Domain.Entities
{
    public class ProductEntity
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(256)]
        public string ProductName { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ProductPrice { get; set; }

        public bool IsDeleted { get; set; } = false;

        public ICollection<ProductOrderEntity> ProductOrders { get; set; } = new List<ProductOrderEntity>();
    }

}
