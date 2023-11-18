
using WebApi.Iservices.Dto;
using WebApi.Models;

namespace WebApi.Iservices
{
    public interface ICategoryService
    {
        public Task<List<Category>> GetCategoriesAsync();
        public Task<Category> AddCategory(CategoryRequest request);
        public Task<Category> EditCategory(CategoryRequest request);
        public Task<Category> DeleteCategory(int id);
    }
}
