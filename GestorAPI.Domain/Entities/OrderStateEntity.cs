using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionAPI.Domain.Entities
{
    public class OrderStateEntity
    {
        [Key]
        public int OrderStateId { get; set; }

        [Required]
        [StringLength(60)]
        public string OrderStateName { get; set; } = string.Empty;

        [Required]
        [StringLength(90)]
        public string OrderColor { get; set; } = string.Empty;

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public UserEntity CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime DeletedAt { get; set; }

        public ICollection<OrderEntity> Orders { get; set; } = new List<OrderEntity>();

    }
}
