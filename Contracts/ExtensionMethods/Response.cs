using Contracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;

namespace Contracts.ExtensionMethods
{
    public static class Response
    {
        public static ProductResponse ToResponse(this Product product, double rate , string CatName)
        {
            return new ProductResponse
            {
                CategoryName = CatName,
                Description = product.Description,
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Rate = rate,
                stock = product.stock
            };
        }
    }
}
