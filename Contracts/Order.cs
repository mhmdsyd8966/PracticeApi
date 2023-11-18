using Microsoft.AspNetCore.Mvc;
using WebApi.Iservices.Dto;

namespace WebApi.Iservices
{
    public interface Order
    {
        public IActionResult AddOrder(OrderRequest request);
        public IActionResult DeleteOrder(int id);
    }
}
