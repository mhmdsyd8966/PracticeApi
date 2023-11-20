using Contracts.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Iservices;
using WebApi.Models;
using WebApi.Models.Context;

namespace Services
{
    
    
    internal class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;
        private readonly OrderService _orderService;    
        public UserService(ApplicationDbContext context,OrderService orderservice)
        {
            _context = context;
            _orderService = orderservice;
        }
        public Task<Rate> AddRate(int ProductId,int Rate,int id)
        {
            var user = _context.users.Find(id);
            var product = _context.products.Find(ProductId);
            var ProductRate = new Rate
            {
                User = user,
                Product = product,
                rate = Rate
            };
            _context.rate.Add(ProductRate);
            _context.SaveChanges();
            return Task.FromResult(ProductRate);
        }


        public Task<Cart> AddToMyCart(int ProductId,int Id)
        {
            var product = _context.products.Find(ProductId);
            var cart = _context.carts.FirstOrDefault(e=>e.Id==Id);
            if(cart==null)
                throw new ArgumentException(nameof(cart));
            if(ProductId==null)
                throw new ArgumentException(nameof(ProductId));
            cart.products.Add(product);
            _context.SaveChanges();
            return Task.FromResult(cart);

        }


        public Task<Cart> DeleteMyCart(int CartId)
        {
            
            
            var Cart = _context.carts.Find(CartId);
            if (Cart == null)
                throw new ArgumentException(nameof(Cart));
            _context.carts.Remove(Cart);
            _context.SaveChanges();
            return Task.FromResult(Cart);
        }

        public async Task<List<Users>> DeleteUser(int id)
        {
            if(id == null)
                throw new ArgumentNullException("id");
            var User = _context.users.Find(id);
            if(User == null)
                throw new ArgumentException(nameof(User));  
            _context.users.Remove(User);
            _context.SaveChangesAsync();
            return await _context.users.ToListAsync();
        }

        public Task<Cart> EditMyCart(int CartId,CartRequest request)
        {
            var cart = _context.carts.FirstOrDefault(e=>e.Id==CartId);
            cart.products = request.products;
            cart.IsCheckout = request.IsCheckout;
            if (cart.IsCheckout == true)
            {
                _orderService.AddOrder(cart);

                DeleteMyCart(CartId);
                return Task.FromResult(cart);
            }
            return Task.FromResult(cart);
        }

        public Task<Users> EditUser(int id, UserRequest request)
        {
          var user = _context.users.FirstOrDefault(e=>e.Id==id);
            user.FullName = request.FullName; user.Email = request.Email; user.UserName = request.UserName;user.Password = request.Password;user.Phone = request.Phone;user.Address = request.Address;
            _context.SaveChanges();
            return Task.FromResult(user);
        }

        public Task<Cart> GetMyCart(int CartId)
        {
            var cart = _context.carts.Find(CartId);
            return Task.FromResult(cart);
        }

        public Task<List<Order>> GetMyOrders(int id)
        {
            var orders = _context.orders.Where(e=>e.UserId==id).ToList();
            return Task.FromResult(orders);

        }
    }
}
