using Entity;

namespace Contracts.Dto
{
    public class CategoryRequest
    {
        public string Name { get; set; }
        public Category ToCategory()
        {
            return new Category() { Name = Name };
        }
    }
}
