using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Iservices;
using WebApi.Iservices.Dto;

namespace zzApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;

        }

        [HttpGet]
        public IActionResult GetAllCategories() 
        {
            var categories = _categoryService.GetCategoriesAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var categories = _categoryService.GetCategory(id);
            return Ok(categories);
        }

        [HttpPost]
        public IActionResult AddCategory(CategoryRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var category = _categoryService.AddCategory(request);
            return Ok(category);
        }

        [HttpPut("{id}")]
        public IActionResult EditCAtegory(int id,CategoryRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var category = _categoryService.EditCategory(id, request);
            return Ok(category);
        }

        [HttpDelete("{id}")]
        public IActionResult DEleteCategory(int id)
        {
            var category = _categoryService.DeleteCategory(id);
            return Ok(category);
        }
    }
}
