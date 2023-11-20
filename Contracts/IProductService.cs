using Contracts.Dto;
using WebApi.Iservices.Dto;
using WebApi.Models;

namespace WebApi.Iservices
{
    public interface IProductService
    {
        public Task<ProductResponse> AddProduct(ProductRequest request);
        public Task<ProductResponse> EditProduct(int id,ProductRequest request);
        public Task<ProductResponse> DeleteProduct(int id);
        public Task<List<ProductResponse>> GetAllProducts ();
        public Task<ProductResponse> GetProductById(int id);
        public double GetProductRate(int id);
        public int GetOrderedTimes(int id);
    }
}
