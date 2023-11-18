using Microsoft.AspNetCore.Mvc;
using WebApi.Iservices.Dto;
using WebApi.Models;

namespace WebApi.Iservices
{
    public interface IProductService
    {
        public IActionResult AddProduct(ProductRequest request);
        public IActionResult EditProduct(ProductRequest request);
        public IActionResult DeleteProduct(int id);
        public List<ActionResult<Product>> GetAllProducts ();
        public IActionResult GetProductById(int id);
        public IActionResult GetProductRate(int id);
        public IActionResult GetOrderedTimes(int id);
    }
}
