using System.ComponentModel.DataAnnotations;

namespace WebApi.Iservices.Dto
{
    public class UserRegister
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string UserName { get; set; }
        
        
    }
}
