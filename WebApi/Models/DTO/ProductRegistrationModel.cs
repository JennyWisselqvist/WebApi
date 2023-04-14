using Microsoft.EntityFrameworkCore;
using WebApi.Models.Entities;

namespace WebApi.Models.DTO
{
    public class ProductRegistrationModel
    {
        public string ArticleNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public string CategoryName { get; set; } = null!;
        public static implicit operator ProductEntity(ProductRegistrationModel model)
        {
            return new ProductEntity
            {
                ArticleNumber = model.ArticleNumber,
                Name = model.Name,
                Description = model.Description,
                Price = model.Price

            };
        }
        public static implicit operator CategoryEntity(ProductRegistrationModel model)
        {
            return new CategoryEntity
            {
                CategoryName = model.CategoryName
            };
        }
        public static implicit operator CategoryRegistrationModel(ProductRegistrationModel model)
        {
            return new CategoryRegistrationModel
            {
                CategoryName = model.CategoryName
            };
        }
    }
}
