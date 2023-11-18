using Microsoft.AspNetCore.Mvc;
using WebApi.Iservices.Dto;

namespace WebApi.Iservices
{
    public interface Login
    {
        public IActionResult Login(UserLogin login);

    }
}
