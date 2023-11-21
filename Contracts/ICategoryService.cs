
using WebApi.Iservices.Dto;
using WebApi.Models;

namespace WebApi.Iservices
{
    public interface ICategoryService
    {
        public Task<List<Category>> GetCategoriesAsync();
        public Task<Category> GetCategory(int id);
        public Task<Category> AddCategory(CategoryRequest request);
        public Task<Category> EditCategory(int id, CategoryRequest request);
        public Task<Category> DeleteCategory(int id);
    }
}
