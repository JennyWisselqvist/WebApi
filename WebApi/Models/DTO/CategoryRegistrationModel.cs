using WebApi.Models.Entities;

namespace WebApi.Models.DTO
{
    public class CategoryRegistrationModel
    {
        public string CategoryName { get; set; } = null!;
        public static implicit operator CategoryEntity(CategoryRegistrationModel model)
        {
            return new CategoryEntity
            {
                CategoryName = model.CategoryName
            };
        }
    }
}
