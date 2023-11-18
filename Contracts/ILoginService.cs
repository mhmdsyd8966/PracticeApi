using Contracts.Dto;

namespace Contracts
{
    public interface ILoginService
    {
        public Task<UserLogin> Login(UserLogin login);

    }
}
