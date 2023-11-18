

using WebApi.Models;

namespace WebApi.Iservices
{
    public interface IUserService
    {
        public Task<List<Users>> DeleteUser(int id);
        public Task<Users> EditUser(int id);
        public Task<Cart> GetMyCart (int id);
        public Task<Rate> AddRate(int ProductId);
        public Task<Cart> AddToMyCart (int ProductId);
        public Task<Cart> EditMyCart(int CartId);
        public Task<Cart> DeleteMyCart(int CartId);
        public Task<List<Order>> GetMyOrders (int id);
        public Task<Order> CheckoutOrder (int id);


    }
}
