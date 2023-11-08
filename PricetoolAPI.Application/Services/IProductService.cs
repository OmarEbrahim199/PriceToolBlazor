using PricetoolAPI.Application.DTOs;

namespace PricetoolAPI.Application.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAllProductsAsync();
    }
}