using ecommerce.Dto;
using ecommerce.Model;

namespace ecommerce.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<Categories>> GetAllCategories();
        Task<Categories> GetById(int id);
        Task<Categories> CreateCategory(CategoryDto categoryDto);
        Task<Categories> UpdateCategory(int id, CategoryDto categoryDto);

        Task<Categories> DeleteCategory(int id);

    }
}
