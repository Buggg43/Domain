using Domain.DTOs;

namespace Domain.Services
{
    public interface IProductServices
    {
        IEnumerable<ProductDto> GetAll();
    }
}
