using Microsoft.AspNetCore.Mvc;
using WebApi.Iservices.Dto;
using WebApi.Models;

namespace WebApi.Iservices
{
    public interface ICategoryService
    {
        public Task<ActionResult<List<Category>>> AddCategory(CategoryRequest request);
        public IActionResult EditCategory(CategoryRequest request);
        public IActionResult DeleteCategory(int id);
    }
}
