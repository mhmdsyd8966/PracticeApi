using WebApi.Iservices.Dto;
using WebApi.Models;

namespace WebApi.Iservices
{
    public interface IOrderService
    {
        public Task<List<Order>> AddOrder(OrderRequest request);
        public Task<List<Order>> DeleteOrder(int id);
    }
}
