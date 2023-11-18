using Microsoft.Identity.Client;

namespace WebApi.Iservices.Dto
{
    public class UserLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
