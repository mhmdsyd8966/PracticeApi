using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
        public List<Product>? SellerProducts { get; set; }
        [ForeignKey("MyCart")]
        public int CartId { get; set; }
        public Cart MyCart { get; set; }
        public List<Rate> MyRates { get; set; }
    }
}
