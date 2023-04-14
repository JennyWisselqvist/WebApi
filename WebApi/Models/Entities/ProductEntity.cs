using System.ComponentModel.DataAnnotations;
using WebApi.Models.DTO;

namespace WebApi.Models.Entities
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }
        public string ArticleNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public CategoryEntity Category { get; set; } = null!;
        public static implicit operator ProductModel(ProductEntity entity)
        {
            return new ProductModel
            {
                Id = entity.Id,
                ArticleNumber = entity.ArticleNumber,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                CategoryName = entity.Category.CategoryName
            };
        }
    }
}
