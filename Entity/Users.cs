using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class Users : IdentityUser
    {
        public string Role { get; set; }
        public List<Product>? SellerProducts { get; set; }
        [ForeignKey("MyCart")]
        public int CartId { get; set; }
        public Cart MyCart { get; set; }
        public List<Rate> MyRates { get; set; } 
    }
}
