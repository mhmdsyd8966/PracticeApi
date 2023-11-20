using WebApi.Iservices.Dto;
using WebApi.Models;

namespace WebApi.Iservices
{
    public interface IOrderService
    {
        public Task<Order> AddOrder(Cart cart);
        public Task<List<Order>> DeleteOrder(int id);
    }
}
