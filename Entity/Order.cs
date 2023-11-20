using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public bool IsDelivered { get; set; }
        public bool IsCanceled { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public Users User { get; set; }
        public string Address { get; set; }
        public List<Product> products { get; set; }
    }
}