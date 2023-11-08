using Microsoft.EntityFrameworkCore;
using PricetoolAPI.Domain;
using PricetoolAPI.Domain.Entities;

namespace PricetoolAPI.DataAccess.Repositories
{
    public class CorporateRepository : ICorporateRepository
    {
        private readonly DataContext _context;

        public CorporateRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Corporate?> GetCorporateByCvrWithSubsidiariesAsync(int cvr)
        {
            return await _context.Corporates
                .Include(c => c.Subsidiaries)
                .FirstOrDefaultAsync(c => c.Cvr == cvr)
                ?? throw new KeyNotFoundException($"No corporate found with CVR: {cvr}");
        }

        public async Task<IEnumerable<Corporate>> GetAllCorporatesAsync()
        {
            return await _context.Corporates.ToListAsync();
        }

    }
}
