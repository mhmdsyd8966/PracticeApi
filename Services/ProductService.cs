using Contracts.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Iservices;
using WebApi.Iservices.Dto;
using WebApi.Models;
using WebApi.Models.Context;
using Contracts.Dto;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    internal class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        { 
            _context = context;
        }
        public Task<ProductResponse> AddProduct(ProductRequest request)
        {
            var product = request.ToProduct();
            _context.products.Add(product);
            _context.SaveChanges();
            var response = product.ToResponse(GetProductRate(product.Id), product.ProductCategory.Name);
            return Task.FromResult(response);
        }

        public Task<ProductResponse> DeleteProduct(int id)
        {
            var product = _context.products.FirstOrDefault(x => x.Id == id);
            if (product != null)
                throw new ArgumentException(nameof(product));
            _context.products.Remove(product);
            _context.SaveChanges();
            return Task.FromResult(product.ToResponse(GetProductRate(product.Id), product.ProductCategory.Name));
        }

        public Task<ProductResponse> EditProduct(int id,ProductRequest request)
        {
            var product = _context.products.FirstOrDefault(x => x.Id == id);
            if (product != null)
                throw new ArgumentException(nameof(product));
            product.Price = request.Price;
            product.Description = request.Description;
            product.Name = request.Name;
            product.stock = request.Stock;
            _context.SaveChanges();
            return Task.FromResult(product.ToResponse(GetProductRate(product.Id), product.ProductCategory.Name));
        }

        public Task<List<ProductResponse>> GetAllProducts()
        {
            var productsResponse = new List<ProductResponse>();
            var products = _context.products.ToList();
            foreach (var product in products)
                productsResponse.Add(product.ToResponse(GetProductRate(product.Id), product.ProductCategory.Name));
            return Task.FromResult(productsResponse);

        }

        public int GetOrderedTimes(int id)
        {
            var ordersCount =
                _context.products
                .Where(x=>x.Id==id)
                .Include("OrderedList")
                .Select(x=>x.OrderedList)
                .Count();
            return ordersCount;
        }

        public Task<ProductResponse> GetProductById(int id)
        {
            var product = _context.products.Find(id);
            if (product == null)
                throw new ArgumentException(nameof(product));
            return Task.FromResult(product.ToResponse(GetProductRate(product.Id), product.ProductCategory.Name));
        }

        public double GetProductRate(int id)
        {
            var ordersCount =
                _context.products
                .Where(x => x.Id == id)
                .Include("ProductRates")
                .Select(x => x.ProductRates).FirstOrDefault().Select(x=>x.rate);
            
            return ordersCount.Sum()/ordersCount.Count();
        }
    }
}
