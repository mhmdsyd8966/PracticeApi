using Entity;

namespace Contracts.Dto
{
    public class ProductRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public Product ToProduct()
        {
            return new Product { Name = Name, Description = Description, Price = Price, stock = Stock };
        }
    }
}
