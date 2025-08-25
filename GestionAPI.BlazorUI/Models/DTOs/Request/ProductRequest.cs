namespace GestionAPI.BlazorUI.Models.DTOs.Request
{
    public class ProductRequest
    {
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public int ProductStock {  get; set; }
        public decimal ProductPrice { get; set; }
    }
}
