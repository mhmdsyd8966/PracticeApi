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

namespace Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;
        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<Category> AddCategory(CategoryRequest request)
        {
            var category = request.ToCategory();
            _context.categories.Add(category);
            var response = category.ToResponse();
            return Task.FromResult(response);
        }

        public Task<Category> DeleteCategory(int id)
        {
            var cat = _context.categories.FirstOrDefault(c => c.Id == id);
            if (cat != null)
            {
                _context.categories.Remove(cat);
                _context.SaveChanges();
                return Task.FromResult(cat.ToResponse());
            }
            throw new ArgumentException(nameof(cat));
        }

        public Task<Category> EditCategory(int id,CategoryRequest request)
        {
            var response = _context.categories.FirstOrDefault(x => x.Id == id);
            if (response != null)
            {
                response.Name = request.Name;
                _context.SaveChanges();
                return Task.FromResult(response.ToResponse());
            }
            throw new ArgumentException(nameof(response));
        }

        public Task<List<Category>> GetCategoriesAsync()
        {
            var categories = _context.categories.ToList();
            var response = new List<Category>();
            foreach (var category in categories)
                response.Add(category.ToResponse());
            return Task.FromResult(response);
        }

        public Task<Category> GetCategory(int id)
        {
            var category = _context.categories.Find(id);
            if (category == null)
                throw new ArgumentException(nameof(category));
            return Task.FromResult(category.ToResponse());
        }
    }
}
