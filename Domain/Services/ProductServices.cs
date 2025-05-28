using Domain.Domain;
using Domain.DTOs;

namespace Domain.Services
{
    public class ProductServices : IProductServices
    {
        private static readonly List<Product> _products = new()
        {
            new() { Id = Guid.NewGuid(), Name = "Mleko", Price = 2.50m },
            new() { Id = Guid.NewGuid(), Name = "Chleb", Price = 3.20m },
        };

        public IEnumerable<ProductDto> GetAll()
        {
            return _products.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price
            });
        }
    }
}
