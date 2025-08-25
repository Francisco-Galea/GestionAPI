namespace GestionAPI.Application.DTOs.Request
{
    public class ProductRequest
    {
        public string ProductName { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; }
    }
}
