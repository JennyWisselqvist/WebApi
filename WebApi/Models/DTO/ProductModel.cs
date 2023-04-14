using WebApi.Models.Entities;

namespace WebApi.Models.DTO
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ArticleNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public string CategoryName { get; set; } = null!;
    }
}
