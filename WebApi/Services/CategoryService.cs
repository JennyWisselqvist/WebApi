using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApi.Contexts;
using WebApi.Models.DTO;
using WebApi.Models.Entities;

namespace WebApi.Services
{
    public class CategoryService
    {
        private readonly DataContext _context;
        public CategoryService(DataContext context)
        {
            _context = context;
        }
        public async Task<CategoryModel> GetAsync(Expression<Func<CategoryEntity, bool>> expression)
        {
            var category = await _context.categories.FirstOrDefaultAsync(expression);
            if (category != null)
                return category!;
            return null!;
        }
        public async Task<int> CreateAsync(CategoryRegistrationModel model)
        {
            CategoryEntity categoryEntity = model;
            _context.categories.Add(categoryEntity);
            await _context.SaveChangesAsync();

            return categoryEntity.Id;
        }
        
    }
}
