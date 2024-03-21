using ecommerce.Data;
using ecommerce.Dto;
using ecommerce.Interfaces;
using ecommerce.Mapper;
using ecommerce.Model;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public CategoryRepository(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
            
        }


        public async Task<Categories> CreateCategory(CategoryDto categoryDto)
        {
            var category = categoryDto.ToCategory();
            await _dbContext.AddAsync(category);
            await _dbContext.SaveChangesAsync();
            return category;
        }

        public async Task<Categories> DeleteCategory(int id)
        {
            var category = await _dbContext.Category.FirstOrDefaultAsync(x=>x.id == id);
            if (category == null) { return null; }
            _dbContext.Category.Remove(category);
            await _dbContext.SaveChangesAsync();    
            return category;
        }

        public async Task<List<Categories>> GetAllCategories()
        {
            var categories= await _dbContext.Category.ToListAsync();
            if (categories.Count == 0) { return null; }
            return categories;
        }

        public  async Task<Categories> GetById(int id)
        {

            var category = await _dbContext.Category.FirstOrDefaultAsync(x => x.id == id);
            if (category == null) { return null; }
            return category;


        }

        public async Task<Categories> UpdateCategory(int id, CategoryDto categoryDto)
        {
            var category = await _dbContext.Category.FirstOrDefaultAsync(x => x.id == id);
            if (category == null) { return null; }
            category.name= categoryDto.name;
            await _dbContext.SaveChangesAsync();
            return category;

        }
    }
}
