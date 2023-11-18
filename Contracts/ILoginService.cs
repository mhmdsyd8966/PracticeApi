using WebApi.Iservices.Dto;

namespace WebApi.Iservices
{
    public interface ILoginService
    {
        public Task<UserLogin> Login(UserLogin login);

    }
}
