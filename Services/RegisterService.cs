using Microsoft.EntityFrameworkCore.Internal;
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
    internal class RegisterService : IRegisterService
    {
        private readonly ApplicationDbContext _context;
        public RegisterService(ApplicationDbContext context)
        {
            _context=context;
        }
        public void Register(UserRegister userRegister)
        {
            var user = new Users
            {
                Address = userRegister.Address,
                Email = userRegister.Email,
                FullName = userRegister.FirstName + userRegister.LastName,
                Password = userRegister.Password,
                Phone = userRegister.PhoneNumber,
                UserName = userRegister.UserName,
                Role = "User"
            };
            _context.users.Add(user);
            _context.SaveChanges();

        }
    }
}
