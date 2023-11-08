using Prisværktøj.Infrastructure.Models;

namespace Prisværktøj.Infrastructure.Services
{
    public interface IProductService
    {
        IEnumerable<ProductDetail> GetAllProductDetails();
    }
}
