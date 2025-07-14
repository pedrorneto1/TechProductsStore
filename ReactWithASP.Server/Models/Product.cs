namespace Tech_Products.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; } // fix: price numeric type
        public string? BatchNumber { get; set; }
    }
}
