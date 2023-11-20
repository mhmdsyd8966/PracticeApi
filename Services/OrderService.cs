using Microsoft.EntityFrameworkCore;
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
    internal class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;
        public OrderService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Order> AddOrder(Cart cart)
        {
            if (cart == null) 
                throw new ArgumentNullException(nameof(cart));
            var user = _context.users.Find(cart.UserId);
            var order = new Order
            {
                products = cart.products,
                Address = user.Address,
                User=user
            };
            _context.orders.Add(order);
            _context.SaveChanges();
            return await Task.FromResult(order);
        }

        public async Task<List<Order>> DeleteOrder(int id)
        {
            var order = _context.orders.Find(id);
            _context.orders.Remove(order);
            _context.SaveChanges();
            return await _context.orders.ToListAsync();
        }
    }
}
