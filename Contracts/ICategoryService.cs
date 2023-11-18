using Contracts.Dto;
using Entity;

namespace Contracts
{
    public interface ICategoryService
    {
        public Task<List<Category>> GetCategoriesAsync();
        public Task<Category> AddCategory(CategoryRequest request);
        public Task<Category> EditCategory(CategoryRequest request);
        public Task<Category> DeleteCategory(int id);
    }
}
