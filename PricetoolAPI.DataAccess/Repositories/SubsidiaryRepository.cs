using Microsoft.EntityFrameworkCore;
using PricetoolAPI.Domain;
using PricetoolAPI.Domain.Entities;

namespace PricetoolAPI.DataAccess.Repositories
{
    public class SubsidiaryRepository : ISubsidiaryRepository
    {
        public readonly DataContext _context;

        public SubsidiaryRepository(DataContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Subsidiary>> GetAllSubsidiariesAsync()
        {
            return await _context.Subsidiary.ToListAsync();
        }

        public async Task<Subsidiary?> GetSubsidiaryByCvrAsync(int cvr)
        {
            return await _context.Subsidiary
                .FirstOrDefaultAsync(s => s.Cvr == cvr)
                ?? throw new KeyNotFoundException($"No subsidiary found with CVR: {cvr}");
        }

        public async Task<Subsidiary?> GetSubsidiaryWithProductsByCvrAsync(int cvr)
        {
            return await _context.Subsidiary
                .Include(s => s.Products).
                FirstOrDefaultAsync(s => s.Cvr == cvr)
                ?? throw new KeyNotFoundException($"No subsidiary found with CVR: {cvr}");
        }
    }
}
