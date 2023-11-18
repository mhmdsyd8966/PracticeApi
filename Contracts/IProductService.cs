﻿using Contracts.Dto;
using Entity;

namespace Contracts
{
    public interface IProductService
    {
        public Task<Product> AddProduct(ProductRequest request);
        public Task<Product> EditProduct(ProductRequest request);
        public Task<Product> DeleteProduct(int id);
        public Task<List<Product>> GetAllProducts();
        public Task<Product> GetProductById(int id);
        public double GetProductRate(int id);
        public int GetOrderedTimes(int id);
    }
}
