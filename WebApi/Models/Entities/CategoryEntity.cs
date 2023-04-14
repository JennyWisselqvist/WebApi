using System.ComponentModel.DataAnnotations;
using WebApi.Models.DTO;

namespace WebApi.Models.Entities
{
    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public ICollection<ProductEntity> Products { get; set; } = new List<ProductEntity>();

        public static implicit operator CategoryModel(CategoryEntity entity)
        {
            return new CategoryModel
            {
                Id = entity.Id,
                CategoryName = entity.CategoryName
            };
        }
    }
}