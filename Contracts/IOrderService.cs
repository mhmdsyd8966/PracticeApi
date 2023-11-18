using Contracts.Dto;
using Entity;

namespace Contracts
{
    public interface IOrderService
    {
        public Task<List<Order>> AddOrder(OrderRequest request);
        public Task<List<Order>> DeleteOrder(int id);
    }
}
