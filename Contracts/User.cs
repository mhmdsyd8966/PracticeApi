using Microsoft.AspNetCore.Mvc;

namespace WebApi.Iservices
{
    public interface User
    {
        public IActionResult DeleteUser(int id);
        public IActionResult EditUser(int id);
        public IActionResult GetMyCart (int id);
        public IActionResult AddRate(int ProductId);
        public IActionResult AddToMyCart (int ProductId);
        public IActionResult EditMyCart(int CartId);
        public IActionResult DeleteMyCart(int CartId);
        public IActionResult GetMyOrders (int id);
        public IActionResult CheckoutOrder (int id);


    }
}
