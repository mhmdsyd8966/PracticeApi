using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int stock { get; set; }
        [ForeignKey("Seller")]
        public string SellerId { get; set; }
        public Users Seller { get; set; }
        public List<Rate> ProductRates { get; set; }
        public Category ProductCategory { get; set; }
        public List<Order> OrderedList { get; set; }
    }
}