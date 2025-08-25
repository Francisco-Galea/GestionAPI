using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionAPI.Domain.Entities
{
    public class ClientEntity
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        [MaxLength(60)]
        public string ClientName { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string ClientEmail { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string ClientPhoneNumber {  get; set; } = string.Empty;

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public UserEntity CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime DeletedAt { get; set; }

        public ICollection<OrderEntity> Orders { get; set; } = new List<OrderEntity>();

    }
}
