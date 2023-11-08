using PricetoolAPI.Domain.Entities;

namespace PricetoolAPI.Domain
{
    public interface ISubsidiaryRepository
    {
        Task<IEnumerable<Subsidiary>> GetAllSubsidiariesAsync();

        Task<Subsidiary?> GetSubsidiaryByCvrAsync(int cvr);

        Task<Subsidiary?> GetSubsidiaryWithProductsByCvrAsync(int cvr);
    }
}
