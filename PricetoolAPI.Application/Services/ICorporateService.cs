using PricetoolAPI.Application.DTOs;

namespace PricetoolAPI.Application.Services
{
    public interface ICorporateService
    {
        Task<CorporateDTO> GetCorporateByCvrAsync(int cvr);

        Task<IEnumerable<CorporateWithoutSubsidiariesDTO>> GetAllCorporatesAsync();

    }
}
