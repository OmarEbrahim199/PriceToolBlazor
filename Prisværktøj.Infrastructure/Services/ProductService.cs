using Prisværktøj.Infrastructure.Models;
using Prisværktøj.Infrastructure.Repositories;

namespace Prisværktøj.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<ProductDetail> GetAllProductDetails()
        {
            // Here you can add any business logic, orchestrate multiple repo calls, etc.
            return _productRepository.GetAllProductDetails();
        }

    }

}
