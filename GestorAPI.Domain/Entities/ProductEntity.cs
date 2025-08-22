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
        public string ProductName { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ProductPrice { get; set; }

        [Required]
        public int ProductStock { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public UserEntity CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime DeletedAt { get; set; }

        public ICollection<ProductOrderEntity> ProductOrders { get; set; } = new List<ProductOrderEntity>();

    }
}
