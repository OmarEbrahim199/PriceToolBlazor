using PricetoolAPI.Domain.Entities;

namespace PricetoolAPI.Domain
{
    public interface ICorporateRepository
    {
        Task<Corporate?> GetCorporateByCvrWithSubsidiariesAsync(int cvr);

        Task<IEnumerable<Corporate>> GetAllCorporatesAsync();


    }
}
