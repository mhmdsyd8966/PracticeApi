namespace Entity
{
    public class Rate
    {
        public int Id { get; set; }
        public int rate { get; set; }
        public Users User { get; set; }
        public Product Product { get; set; }
    }
}