
using System.ComponentModel.DataAnnotations;

namespace GestionAPI.Domain.Entities
{
    public class ClientEntity
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        [MaxLength(60)]
        public string ClientName { get; set; }

        [Required]
        [MaxLength(100)]
        public string ClientEmail { get; set; }

        public bool IsDeleted { get; set; } = false;

        public ICollection<OrderEntity> Orders { get; set; } = new List<OrderEntity>();
    }
}
