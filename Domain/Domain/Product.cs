namespace Domain.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!; // lub public required string Name { get; set; }
        public decimal Price { get; set; }
    }
}
