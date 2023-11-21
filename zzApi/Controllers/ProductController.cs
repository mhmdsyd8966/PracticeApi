using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Iservices;
using WebApi.Iservices.Dto;

namespace zzApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAllProducts() 
        { 
            var products = _productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _productService.GetProductById(id);
            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct(ProductRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(request);
            var product = _productService.AddProduct(request);
            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult EditProduct(int id,ProductRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(request);
            var product = _productService.EditProduct(id, request);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _productService.DeleteProduct(id);
            return Ok(product);
        }

    }
}
