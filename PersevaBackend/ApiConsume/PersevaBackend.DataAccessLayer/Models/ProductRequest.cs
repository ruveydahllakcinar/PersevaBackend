namespace PersevaBackend.WebApi.Models
{
    public class ProductRequest
    {
        public int ProductId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public decimal? Price { get; set; }
        public string? CoverImage { get; set; }
        public DateTime DateCreated { get; set; }
        public string? Stock { get; set; }
    }
}
