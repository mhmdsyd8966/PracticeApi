

using Contracts.Dto;
using WebApi.Models;

namespace WebApi.Iservices
{
    public interface IUserService
    {
        public Task<List<Users>> DeleteUser(int id);
        public Task<Cart> EditMyCart(int CartId, CartRequest request);
        public Task<Users> EditUser(int id,UserRequest request);
        public Task<Cart> GetMyCart(int CartId);
        public Task<Rate> AddRate(int ProductId, int Rate, int id);

        public Task<Cart> AddToMyCart(int ProductId, int Id);
        public Task<Cart> DeleteMyCart(int CartId);
        public Task<List<Order>> GetMyOrders (int id);


    }
}
