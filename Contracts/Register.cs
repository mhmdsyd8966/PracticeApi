using Microsoft.AspNetCore.Mvc;
using WebApi.Iservices.Dto;

namespace WebApi.Iservices
{
    public interface Register
    {
        public IActionResult Register(UserRegister userRegister);
    }
}
