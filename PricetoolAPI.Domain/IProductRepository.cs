using PricetoolAPI.Domain.Entities;

namespace PricetoolAPI.Domain
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
    }
}
