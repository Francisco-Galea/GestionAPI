using System.ComponentModel.DataAnnotations;

namespace GestionAPI.Domain.Entities
{
    public class UserEntity
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string UserLastName {  get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string UserEmail { get; set; } = string.Empty;

        [Required]
        public string UserPassword { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public DateTime DeletedAt { get; set; }

        public ICollection<ClientEntity> Clients { get; set; } = new List<ClientEntity>();

        public ICollection<OrderEntity> Orders { get; set; } = new List<OrderEntity>();

        public ICollection<ProductEntity> Products { get; set; } = new List<ProductEntity>();

        public ICollection<OrderStateEntity> OrderStates { get; set; } = new List<OrderStateEntity>();

    }
}
