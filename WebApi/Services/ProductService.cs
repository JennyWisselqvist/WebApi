using Microsoft.EntityFrameworkCore;
using WebApi.Contexts;
using WebApi.Models.DTO;
using WebApi.Models.Entities;

namespace WebApi.Services
{
    public class ProductService
    {
        private readonly DataContext _context;
        private readonly CategoryService _categories;
        public ProductService(DataContext context, CategoryService categories)
        {
            _context = context;
            _categories = categories;
        }
        public async Task<IEnumerable<ProductModel>> GetAllAsync()
        {
            var items = await _context.products.Include(x => x.Category).ToListAsync();
            var products = new List<ProductModel>();
            foreach (var item in items)
                products.Add(item);
            
            return products;
        }
        public async Task CreateAsync(ProductRegistrationModel model)
        {
            ProductEntity productEntity = model;

            var categoryModel = await _categories.GetAsync(x => x.CategoryName == model.CategoryName);
            if (categoryModel != null)
                productEntity.CategoryId = categoryModel.Id;
            else
                productEntity.CategoryId = await _categories.CreateAsync(model);

            _context.products.Add(productEntity);
            await _context.SaveChangesAsync();
        }
    }
}
