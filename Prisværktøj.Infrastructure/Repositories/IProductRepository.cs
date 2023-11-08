using Prisværktøj.Infrastructure.Models;

namespace Prisværktøj.Infrastructure.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<ProductDetail> GetAllProductDetails();
    }
}
