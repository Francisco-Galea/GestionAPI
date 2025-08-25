namespace GestionAPI.BlazorUI.Models.DTOs.Response
{
    public class ProductResponse
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
