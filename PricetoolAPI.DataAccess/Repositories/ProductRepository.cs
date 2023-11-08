using Microsoft.EntityFrameworkCore;
using PricetoolAPI.Domain;
using PricetoolAPI.Domain.Entities;

namespace PricetoolAPI.DataAccess.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public readonly DataContext _context;


        public ProductRepository(DataContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Product.ToListAsync();
        }

    }
}
