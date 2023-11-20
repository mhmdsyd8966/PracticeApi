using WebApi.Iservices.Dto;
using WebApi.Models;

namespace WebApi.Iservices
{
    public interface ILoginService
    {
        public Task<Users> Login(UserLogin login);

    }
}
