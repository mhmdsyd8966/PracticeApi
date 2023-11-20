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
    internal class LoginService : ILoginService
    {
        private readonly ApplicationDbContext _context;
        public LoginService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<Users> Login(UserLogin login)
        {
            if (login == null) 
                throw new ArgumentNullException();
            var user = _context.users.FirstOrDefault(e=>e.UserName == login.UserName);
            if (user.Password == login.Password)
            {
                return Task.FromResult(user);
            }
            throw new ArgumentNullException();
        }
    }
}
